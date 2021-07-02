namespace TaleonLtd.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class ContactsController : Controller
    {
        public IActionResult ShowLocation()
        {
            return View();
        }
    }
}
