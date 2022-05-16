using lab8;

Firm firm = new Firm();
firm.AddBasicRate("first rate", 242);
firm.AddDiscountRate("second rate", 358, 20);
firm.AddDiscountRate("third rate" , 204, 12);

Console.WriteLine(firm.FindMinCost());
