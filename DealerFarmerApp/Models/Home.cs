using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DealerFarmerApp.Models
{
  public class Home
  {
  }

  public class RegistrationModel
  {
    [Key]
    public int RegisId { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(50)")]
    public string Name { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(100)")]
    public string Email { get; set; }

    [Required]
    [Column(TypeName = "BIGINT")]
    public int Mobile { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(100)")]
    public string Password { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(100)")]
    public string Address { get; set; }

    [Required]
    public string userTypeId { get; set; }

    [ForeignKey("userTypeId")]
    public UserType UserType { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(50)")]
    public string CityId { get; set; }

    [Required]
    public string StateId { get; set; }

    [ForeignKey("StateId")]
    public StateModel State { get; set; }

    [Required]
    [Column(TypeName = "int")]
    public int ZipCode { get; set; }
  }
  public class UserType
  {
    [Key]
    public string userTypeId { get; set; }
    [Required]
    [Column(TypeName = "nvarchar(50)")]
    public string userTypeName { get; set; }
  }
  public class StateModel
  {
    [Key]
    public string StateId { get; set; }
    [Required]
    [Column(TypeName = "nvarchar(50)")]
    public string StateName { get; set; }
  }
  public class CityModel
  {
    [Key]
    public string CityId { get; set; }
    [Required]
    [Column(TypeName = "nvarchar(50)")]
    public string CityName { get; set; }

    [Required]
    public string StateId { get; set; }

    [ForeignKey("StateId")]
    public StateModel State { get; set; }
  }

  public class FrmRegistrationModel
  {
    [Key]
    public int FrmId { get; set; }

    [Required]
    [Column(TypeName = "float(50)")]
    public float Area { get; set; }

    [Required]
    public int MeasureId { get; set; }

    [ForeignKey("MeasureId")]
    public MeasurementData Measurement { get; set; }

    [Required]
    public int RegisId { get; set; }

    [ForeignKey("RegisId")]
    public RegistrationModel registrationModel { get; set; }
  }

  public class MeasurementData
  {
    [Key]
    public int MeasureId { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(50)")]
    public string MeasureName { get; set; }
  }

  public class DelregistrationModel
  {
    [Key]
    public int DelRegisId { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(50)")]
    public string DealerId { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(50)")]
    public string ShopId { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(50)")]
    public string ShopName { get; set; }

    [Required]
    public int RegisId { get; set; }

    [ForeignKey("RegisId")]
    public RegistrationModel registrationModel { get; set; }
  }


}
