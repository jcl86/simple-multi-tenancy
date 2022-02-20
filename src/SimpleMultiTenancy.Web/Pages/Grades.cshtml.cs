using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SimpleMultiTenancy.Web.Data;

namespace SimpleMultiTenancy.Web.Pages
{
    [Authorize()]
    public class GradesModel : PageModel
    {
        //https://docs.microsoft.com/es-es/aspnet/core/security/authorization/policies?view=aspnetcore-6.0

        private readonly ApplicationDbContext context;

        public IEnumerable<Grade> Grades { get; set; }

        public GradesModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task OnGet(int schoolId)
        {
            Grades = await context.Grades.Where(x => x.SchoolId == schoolId).ToListAsync();
        }
    }
}
