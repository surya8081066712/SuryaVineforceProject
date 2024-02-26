using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SuryaVineforceProject.Country;
using SuryaVineforceProject.State;
using SuryaVineforceProject.State.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuryaVineforceProject.Web.Controllers
{
    public class StateController : Controller
    {
        private readonly IStateAppService _stateAppService;
        private readonly ICountryAppService _countryAppService;

        public StateController(IStateAppService stateAppService, ICountryAppService countryAppService)
        {
            _stateAppService = stateAppService;
            _countryAppService = countryAppService;
        }

        public async Task<ActionResult> Index()
        {
            var states = await _stateAppService.GetAll();
            return View(states);
        }
        public async Task<ActionResult> Create()
        {
            var countries = await _countryAppService.GetAll();
            ViewBag.Countries = new SelectList(countries.Items, "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateStateDto input)
        {
            await _stateAppService.Create(input);
            return RedirectToAction("Index");
        }
        public async Task<ActionResult> Edit(int id)
        {
            var state = await _stateAppService.Get(new EntityDto<int> { Id = id });
            var countries = await _countryAppService.GetAll();
            ViewBag.Countries = new SelectList(countries.Items, "Id", "Name", state.CountryId);
            return View(state);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(UpdateStateDto input)
        {
            await _stateAppService.Update(input);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<ActionResult> Delete(int id)
        {
            await _stateAppService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
