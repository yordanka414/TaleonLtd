namespace TaleonLtd.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using TaleonLtd.Data;

    public class AccidentsController: BaseController
    {
        private readonly ApplicationDbContext db;

        public AccidentsController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<IActionResult> Create()
        {

            return this.View();
        }
    }
}
