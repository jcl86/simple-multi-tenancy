using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace SimpleMultiTenancy.Web.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Claim> Claims { get; set; }

        private readonly UserManager<User> userManager;

        public IndexModel(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }

        public void OnGet()
        {
            Claims = User.Claims;
        }
    }
}