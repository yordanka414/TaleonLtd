namespace TaleonLtd.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using TaleonLtd.Data.Models;
    using TaleonLtd.Web.ViewModels.Customers;

    public class CustomersController: Controller
    {
        public IActionResult Register()
        {

            return this.View();
        }

        [HttpPost]
        public IActionResult Register(CustomerInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }
            var user = new Customer
            {
                FirstName = model.FirstLine,
                LastName = model.
            }
            return this.Ok();
        }
    }
}
