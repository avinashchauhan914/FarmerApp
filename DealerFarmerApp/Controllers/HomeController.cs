using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DealerFarmerApp.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DealerFarmerApp.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class HomeController : ControllerBase
  {
    private readonly IHomeRepository repository;

    public HomeController(IHomeRepository repository)
    {
      this.repository = repository;
    }
    [HttpPost]
    [Route("saveRegistration")]
    public async Task<IActionResult> SaveRegistration(RegistrationModel registrationModel)
    {
      await this.repository.SaveRegistration(registrationModel);
      return Ok();
    }

    [HttpGet]
    [Route("getCityList")]
    public async Task<IActionResult> GetCityList()
    {
      var data = await this.repository.GetCityList();
      return Ok(data);
    }

    [HttpGet]
    [Route("getStateList")]
    public async Task<IActionResult> GetStateList()
    {
      var data = await this.repository.GetStateList();
      return Ok(data);
    }

    [HttpGet]
    [Route("getUserTypeList")]
    public async Task<IActionResult> GetUserTypeList()
    {
      var data = await this.repository.GetUserTypeList();
      return Ok(data);
    }

    [HttpPost]
    [Route("saveFrmRegistration")]
    public async Task<IActionResult> SaveFrmRegistration(FrmRegistrationModel frmRegistrationModel)
    {
      await this.repository.SaveFrmRegistration(frmRegistrationModel);
      return Ok();
    }

    [HttpPost]
    [Route("saveDealerRegistration")]
    public async Task<IActionResult> SaveDealerRegistration(DelregistrationModel delregistrationModel)
    {
      await this.repository.SaveDealerRegistration(delregistrationModel);
      return Ok();
    }

    [HttpGet]
    [Route("getRegistrationList")]
    public async Task<IActionResult> GetRegistrationList()
    {
      var data = await this.repository.GetRegistrationList();
      return Ok(data);
    }

    [HttpGet]
    [Route("getMeasurementData")]
    public async Task<IActionResult> GetMeasurementData()
    {
      var data = await this.repository.GetMeasurementData();
      return Ok(data);
    }

  }
}
