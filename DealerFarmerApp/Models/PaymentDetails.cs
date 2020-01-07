using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DealerFarmerApp.Models
{
  public class PaymentDetails
  {
    [Key]
    public int PMId { get; set; }
    [Required]
    [Column(TypeName = "nvarchar(100)")]
    public string CardOwnername { get; set; }
    [Required]
    [Column(TypeName = "nvarchar(16)")]
    public string CardNumber { get; set; }
    [Required]
    [Column(TypeName = "nvarchar(5)")]
    public string ExpirynDate { get; set; }
    [Required]
    [Column(TypeName = "nvarchar(3)")]
    public string CVV { get; set; }
  }
}
