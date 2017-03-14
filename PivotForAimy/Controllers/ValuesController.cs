using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PivotForAimy.Models;

namespace PivotForAimy.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly Kiwi_UATContext _context;

        public ValuesController(Kiwi_UATContext context)
        {
            _context = context;
        }

        [HttpGet("Dashboard")]
        public IActionResult Dashboard(int siteId, int? termId)
        {
            var spts = _context.SiteProgramTerm
                .Where(spt => SptExistsForSiteAndTerm(spt, siteId, termId))
                .Include(spt => spt.BookingSpt)
                    .ThenInclude(bspt => bspt.Attendance)
                        .ThenInclude(att => att.Child)
                .Include(spt => spt.BookingSpt)
                    .ThenInclude(bspt => bspt.Booking)
                        .ThenInclude(book => book.BookingType)
                .Include(spt => spt.BookingSpt)
                    .ThenInclude(bspt => bspt.Booking)
                        .ThenInclude(book => book.ProgramCategory)
                .SelectMany(spt => spt.BookingSpt
                .SelectMany(bspt => bspt.Attendance
                .Select(att => new
                {
                    ChildName = att.Child.Name,
                    Date = att.Day,
                    BookingType = bspt.Booking.BookingType.Description,
                    ProgramName = spt.Name,
                    CategoryName = bspt.Booking.ProgramCategory.Name,
                    SignIn = att.ActualStartKeyedOn,
                    SignOut = att.ActualEndKeyedOn,
                    Duration = GetDuration(att.ActualStartKeyedOn, att.ActualEndKeyedOn)
                })))
                .ToList();
            
            return Json(spts);
        }

        [HttpGet("GetTermIdsForSite")]
        public IActionResult GetTermIdsForSite(int siteId)
        {
            var result = _context.SiteProgramTerm
                .Where(s => s.SiteId == siteId)
                .Select(s => new
                {
                    Value = s.TermId,
                    Text = s.TermId
                })
                .OrderBy(s => s.Value)
                .Distinct();
            return Json(result);
        }

        [HttpGet("GetSiteIds")]
        public IActionResult GetSiteIds()
        {
            var result = _context.SiteProgramTerm
                .Select(s => new
                {
                    Value = s.SiteId,
                    Text = s.SiteId
                })
                .OrderBy(s => s.Value)
                .Distinct();
            return Json(result);
        }

        private TimeSpan GetDuration(DateTime? start, DateTime? end)
        {
            if (start == null || end == null) return TimeSpan.Zero;
            return end.Value.Subtract(start.Value);
        }

        private bool SptExistsForSiteAndTerm(SiteProgramTerm spt, int siteId, int? termId)
        {
            return spt.SiteId == siteId && (termId == null || spt.TermId == termId);
        }

        [HttpGet("Children")]
        public IActionResult Children()
        {
            var result = _context.Child.ToList();
            return Json(result);
        }

        [HttpGet("Orgs")]
        public IActionResult Orgs()
        {
            var result = _context.Org.ToList();
            return Json(result);
        }

        [HttpGet("OrgChildren")]
        public IActionResult OrgChildren()
        {
            var result = _context.OrgChild.Include(c => c.Child).Include(c => c.Site)
                .Select(c => new { ChildName = c.Child.Name, SiteName = c.Site.Name }).ToList();
            //var result = new object[] {
            //    new { ChildName = "Hyungoo", SiteName = "Epsom" },
            //    new { ChildName = "Boram", SiteName = "Albany" }
            //};
            return Json(result);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
