using System.ComponentModel.DataAnnotations;

namespace TreatShop.Models 
{
  public class Treat 
  {
    public int TreatId { get; set; }

    [Required(ErrorMessage = "The Treat name field can't be empty!")]
    public string Name { get; set; }
    public List<TreatFlavor> JoinEntities { get; set; }
  }
}