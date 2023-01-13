using System.ComponentModel.DataAnnotations;

namespace TreatShop.Models 
{
  public class Flavor 
  {
    public int FlavorId { get; set; }

    [Required(ErrorMessage = "The Flavor name field can't be empty!")]
    public string Name { get; set; }
    public List<TreatFlavor> JoinEntities { get; set; }
  }
}