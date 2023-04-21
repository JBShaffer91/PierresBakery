using Xunit;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  public class PartryTests
  {
    [Fact]
  public void CalculatePrice_SinglePastry_ReturnsCorrectPrice()
  {
    Pastry pastry = new Pastry(1);
    int price = pastry.CalculatePrice();
    Assert.Equal(2, price);
  }

  [Fact]
  public void CalculatePrice_ThreePastries_ReturnsCorrectPrice()
  {
    Pastry pastry = new Pastry(3);
    int price = pastry.CalculatePrice();
    Assert.Equal(6, price);
  }

  [Fact]
    public void CalculatePrice_FourPastries_ReturnsCorrectPrice()
    {
      Pastry pastry = new Pastry(4);
      int price = pastry.CalculatePrice();
      Assert.Equal(6, price);
    }

    [Fact]
    public void CalculatePrice_TwelvePastries_ReturnsCorrectPrice()
    {
      Pastry pastry = new Pastry(12);
      int price = pastry.CalculatePrice();
      Assert.Equal(18, price);
    }
  }
}