using System.Collections.Generic;

namespace BestRestaurant.Models
{
  public class Restaurant
  {
    public Restaurant()
    {
      Menu = new HashSet<Dish>();
    }
    public virtual ICollection<Dish> Menu { get; set; }

    public int RestaurantId { get; set; }

    public string Name { get; set; }

    public double RoomRating { get; set; }


  }
}