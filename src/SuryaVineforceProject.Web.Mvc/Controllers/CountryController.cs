using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc;
using SuryaVineforceProject.Country;
using SuryaVineforceProject.Country.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuryaVineforceProject.Web.Controllers
{
    public class CountryController : Controller
    {
        private readonly ICountryAppService _countryAppService;

        public CountryController(ICountryAppService countryAppService)
        {
            _countryAppService = countryAppService;
        }

        public async Task<ActionResult> Index()
        {
            var countries = await _countryAppService.GetAll();
            return View(countries);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateCountryDto input)
        {
            await _countryAppService.Create(input);
            return RedirectToAction("Index");
        }
        public async Task<ActionResult> Edit(int id)
        {
            var country = await _countryAppService.Get(new EntityDto<int> { Id = id });
            return View(country);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(UpdateCountryDto input)
        {
            await _countryAppService.Update(input);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<ActionResult> Delete(int id)
        {
            await _countryAppService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
