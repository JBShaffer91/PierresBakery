namespace PierresBakery.Models
{
  public class Pastry
  {
    public int Quantity { get; set; }
    public Pastry(int quantity)
    {
      Quantity = quantity;
    }

    public int CalculatePrice()
    {
      int freePastries = Quantity / 4;
      int paidPastries = Quantity - freePastries;
      int price = paidPastries * 2;
      return price;
    }
  }
}