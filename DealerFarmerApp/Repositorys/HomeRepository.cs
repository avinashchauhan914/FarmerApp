using DealerFarmerApp.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DealerFarmerApp.Repositorys
{
  public class HomeRepository : IHomeRepository
  {
    private readonly ApplicationDbContext context;

    public HomeRepository(ApplicationDbContext context)
    {
      this.context = context;
    }

    public async Task<IEnumerable<CityModel>> GetCityList()
    {
      var list = await this.context.cityModels.FromSqlRaw($"GetCityData").ToListAsync();
      return list;
    }

    public async Task<IEnumerable<StateModel>> GetStateList()
    {
      var list = await this.context.stateModels.ToListAsync();
      return list;
    }

    public async Task<IEnumerable<UserType>> GetUserTypeList()
    {
      var list = await this.context.userTypes.ToListAsync();
      return list;
    }

    public async Task<RegistrationModel> SaveRegistration(RegistrationModel registrationModel)
    {
      await this.context.registrationModels.AddAsync(registrationModel);
      this.context.SaveChanges();

      return registrationModel;

    }

    public async Task<FrmRegistrationModel> SaveFrmRegistration(FrmRegistrationModel frmRegistrationModel)
    {
      await this.context.frmRegistrationModels.AddAsync(frmRegistrationModel);
      this.context.SaveChanges();

      return frmRegistrationModel;

    }

    public async Task<DelregistrationModel> SaveDealerRegistration(DelregistrationModel delregistrationModel)
    {
      await this.context.delregistrationModels.AddAsync(delregistrationModel);
      this.context.SaveChanges();

      return delregistrationModel;

    }

    public async Task<IEnumerable<RegistrationModel>> GetRegistrationList()
    {
      var list = await this.context.registrationModels.FromSqlRaw($"GetRegistrationList").ToListAsync();
      return list;
    }

    public async Task<IEnumerable<MeasurementData>> GetMeasurementData()
    {
      var list = await this.context.measurementDatas.FromSqlRaw($"GetMeasurementData").ToListAsync();
      return list;
    }

  }
}
