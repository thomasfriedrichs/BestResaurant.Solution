using System.Collections.Generic;

namespace BestRestaurant.Models
{
  public class Restaurant
  {
    public Restaurant()
    {
      Dishes = new HashSet<Dish>();
    }
    public virtual ICollection<Dish> Dishes { get; set; }

    public int RestaurantId { get; set; }

    public string Name { get; set; }

    public int RoomRating { get; set; }


  }
}