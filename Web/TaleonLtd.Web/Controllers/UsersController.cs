namespace TaleonLtd.Web.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    using TaleonLtd.Data;
    using TaleonLtd.Web.ViewModels.Users;

    [Area("Identity")]
    public class UsersController : BaseController
    {
        private readonly ApplicationDbContext db;

        public UsersController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult RegisterUsersDetails()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult RegisterUsersDetails(UserInputModel input)
        {

            return this.View();
        }

    }
}
