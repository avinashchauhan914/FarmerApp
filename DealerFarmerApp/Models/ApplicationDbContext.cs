using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DealerFarmerApp.Models
{
  public class ApplicationDbContext: DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {

    }

    public DbSet<PaymentDetails> paymentDetail { get; set; }
    public DbSet<RegistrationModel> registrationModels { get; set; }
    public DbSet<CityModel> cityModels { get; set; }
    public DbSet<StateModel> stateModels { get; set; }
    public DbSet<UserType> userTypes { get; set; }
    public DbSet<FrmRegistrationModel> frmRegistrationModels { get; set; }
    public DbSet<MeasurementData> measurementDatas { get; set; }
    public DbSet<DelregistrationModel> delregistrationModels { get; set; }


  }
}
