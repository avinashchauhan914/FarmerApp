using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DealerFarmerApp.Models
{
  public interface IHomeRepository
  {
    public Task<RegistrationModel> SaveRegistration(RegistrationModel registrationModel);
    public Task<IEnumerable<CityModel>> GetCityList();
    public Task<IEnumerable<StateModel>> GetStateList();
    public Task<IEnumerable<UserType>> GetUserTypeList();
    public Task<FrmRegistrationModel> SaveFrmRegistration(FrmRegistrationModel frmRegistrationModel);
    public Task<DelregistrationModel> SaveDealerRegistration(DelregistrationModel delregistrationModel);
    public Task<IEnumerable<RegistrationModel>> GetRegistrationList();
    public Task<IEnumerable<MeasurementData>> GetMeasurementData();
  }
}
