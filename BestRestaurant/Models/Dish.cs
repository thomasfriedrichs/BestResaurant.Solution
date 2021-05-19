namespace BestRestaurant.Models
{
  public class Dish
  {
    public int DishId { get; set; }

    public int Rating { get; set; }
    public string Description { get; set; }
    public int RestaurantId { get; set; }
    public virtual Restaurant Restaurant { get; set; }
  }
}