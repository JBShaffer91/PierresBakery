using Xunit;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  public class BreadTests
  {
    [Fact]
    public void CalculatePrice_SingleLoaf_ReturnsCorrectPrice()
    {
      Bread bread = new Bread(1);
      int price = bread.CalculatePrice();
      Assert.Equal(5, price);
    }

    [Fact]
    public void CalculatePrice_TwoLoaves_ReturnsCorrectPrice()
    {
      Bread bread = new Bread(2);
      int price = bread.CalculatePrice();
      Assert.Equal(10, price);
    }
    [Fact]
    public void CalculatePrice_ThreeLoaves_ReturnsCorrectPrice()
    {
    Bread bread = new Bread(3);
    int price = bread.CalculatePrice();
    Assert.Equal(10, price);
    }

    [Fact]
    public void CalculatePrice_TenLoaves_ReturnsCorrectPrice()
    {
    Bread bread = new Bread(10);
    int price = bread.CalculatePrice();
    Assert.Equal(35, price);
    }
  }
}