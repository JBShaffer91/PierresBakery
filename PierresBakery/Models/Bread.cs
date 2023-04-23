namespace PierresBakery.Models
{
  public class Bread
  {
    public int Quantity { get; set; }
    public Bread(int quantity)
    {
      Quantity = quantity;
    }

    public int CalculatePrice()
    {
      int freeLoaves = Quantity / 3;
      int paidLoaves = Quantity - freeLoaves;
      int price = paidLoaves * 5;
      return price;
    }
  }
}