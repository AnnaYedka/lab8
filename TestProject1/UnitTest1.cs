using Xunit;

using lab8;
namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Firm firm = new Firm();
        firm.AddBasicRate("first rate", 242);
        firm.AddDiscountRate("second rate", 358, 20);
        firm.AddDiscountRate("third rate" , 204, 12);
        Assert.Equal("third rate", firm.FindMinCost());
    }
    [Fact]
    public void Test2()
    {
        Firm firm = new Firm();
        firm.AddBasicRate("first rate", 242);
        firm.AddDiscountRate("second rate", 358, 20);
        firm.AddDiscountRate("third rate" , 553, 12);
        Assert.Equal("first rate", firm.FindMinCost());
    }
    
}