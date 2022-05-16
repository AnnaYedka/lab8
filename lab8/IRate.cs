namespace lab8;

public interface IRate
{
    public double GetCost();

}

public class BaseRate : IRate
{
    private double cost;

    public BaseRate(double _cost)
    {
        cost = _cost;
    }
    
    public double GetCost()
    {
        return cost;
    }
}

public class DiscountRate : IRate
{
    private double cost;
    private int rate;

    public DiscountRate(double _cost, int _rate)
    {
        cost = _cost;
        rate = _rate;
    }

    public double GetCost()
    {
        return cost - cost * rate / 100;
    }
}

public class Rate
{
    private string name;
    private IRate rate;

    public Rate(string _name, IRate _rate)
    {
        name = _name;
        rate = _rate;
    }

    public double GetCost()
    {
        return rate.GetCost();
    }

    public string GetName()
    {
        return name;
    }
}


public class Firm
{
    private List<Rate> _rates = new List<Rate>();

    public void AddBasicRate(string name, double cost)
    {
        Rate tmp = new Rate(name, new BaseRate(cost));
        _rates.Add(tmp);
    }

    public void AddDiscountRate(string name, double cost, int count)
    {
        Rate tmp = new Rate(name, new DiscountRate(cost, count));
        _rates.Add(tmp);
    }

    public string FindMinCost()
    {
        double count = Double.MaxValue;
        string name = "";
        foreach (Rate a in _rates)
        {
            if (a.GetCost() < count)
            {
                count = a.GetCost();
                name = a.GetName();
            }
        }

        return name;
    }
}
