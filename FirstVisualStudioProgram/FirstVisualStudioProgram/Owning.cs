using System;
class Owning
{
   

   public double yearlyloss { get; set; }
    public double SalePriceNow { get; set; }
    public double propertyhike { get; set; }

    public double lessmortage { get; set; }
   public int Years;
    /*public Owning(int years)
    {
        Years = years;
    } */

    public double SalesCostPercentage { get; set; }

    public double GetAnnualHike()
    {

        double annualhike = ((SalePriceNow) * (propertyhike / 100));
       // Console.WriteLine("Annual Hike is : " + annualhike);
        return annualhike;
    }


    public double ExpectedSalesValue()
    {
        double expectedsalesvalue = (SalePriceNow + ((SalePriceNow) * (propertyhike / 100)));
        //Console.WriteLine("Expected Sales Value is : " + expectedsalesvalue);
        return expectedsalesvalue;
    }
    
public double lesssalecost,moneygainedonowning;
public int years;
    public double LessSaleCost(double SalePriceNow,
                               double propertyhike,
                               double SalesCostPercentage)
    {
        double lesssalecost = ((SalePriceNow + ((SalePriceNow) * (propertyhike / 100)))* ((SalesCostPercentage) / 100));
        //Console.WriteLine("Less Sale Cost Value is : " + lesssalecost);
        return lesssalecost;
    }

    public double MoneyGainedOnOwning(double yearlyloss, double SalePriceNow, double propertyhike, double lessmortage, int years)
    {
        double moneygainedonowning = (((yearlyloss) + (SalePriceNow + ((SalePriceNow) * (propertyhike / 100))) + (lesssalecost) - (lessmortage)) * (years));
        //Console.WriteLine("Money Gained On Selling is : " + moneygainedonowning);
        return moneygainedonowning;

    }

}
