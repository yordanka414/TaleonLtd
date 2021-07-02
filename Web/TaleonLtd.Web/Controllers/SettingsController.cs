namespace TaleonLtd.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Threading.Tasks;
    using TaleonLtd.Data.Common.Repositories;
    using TaleonLtd.Data.Models;
    using TaleonLtd.Services.Data;
    using TaleonLtd.Services.Messaging;
    using TaleonLtd.Web.ViewModels.Settings;

    public class SettingsController : BaseController
    {
        private readonly ISettingsService settingsService;

        private readonly IDeletableEntityRepository<Setting> repository;
        private readonly IEmailSender emailSender;

        public SettingsController(
            ISettingsService settingsService,
            IDeletableEntityRepository<Setting> repository,
            IEmailSender emailSender)
        {
            this.settingsService = settingsService;
            this.repository = repository;
            this.emailSender = emailSender;
        }

        public IActionResult Index()
        {
            var settings = this.settingsService.GetAll<SettingViewModel>();
            var model = new SettingsListViewModel { Settings = settings };
            return this.View(model);
        }


        public async Task<IActionResult> SendEmail()
        {
            var emailTo = "yordanka414@gmail.com";
            await this.emailSender.SendEmailAsync("YordankaKrumova414@gmail.com", "Yordanka", emailTo, "Hello", "<h1>Hello World</h1>");

            return this.Redirect(nameof(this.Index));
        }

        public async Task<IActionResult> InsertSetting()
        {
            var random = new Random();
            var setting = new Setting { Name = $"Name_{random.Next()}", Value = $"Value_{random.Next()}" };

            await this.repository.AddAsync(setting);
            await this.repository.SaveChangesAsync();

            return this.RedirectToAction(nameof(this.Index));
        }
    }
}
