using System;
class Decision
{

  public void IsItWorthSellingOrOwning(int numberOfYears)
  {

    Selling s2 = new Selling();
    double c = s2.GetMoneyLeft(720000, 560500, 3);
    double f = s2.GetMoneyGainedOnSelling(c, 12, numberOfYears);
    Console.WriteLine("The money gained on Selling the property in " +numberOfYears + " years is " + f);
    double sellingbenefit = s2.moneygainedonselling;

    Owning o2 = new Owning();
    o2.LessSaleCost(720000, 4, 3);
    o2.MoneyGainedOnOwning(33319.2, 720000, 4, 560500, numberOfYears);
    Console.WriteLine("The money gained on Owning the property in  " +numberOfYears + " years is " + o2.moneygainedonowning);
    double owningbenefit = o2.moneygainedonowning;

    if (sellingbenefit < owningbenefit)
    {
      Console.WriteLine("Hello Sandeep, Please own the property for benefit. Good Luck! ");
    }
    else
    {
      Console.WriteLine("Hello Sandeep, Please sell the property for benefit. Good Luck! ");

    }
  }


  public void IsItWorthSellingOrOwning()
  {

      
    Selling s = new Selling();
    double a = s.GetMoneyLeft(720000, 560500, 3);
    double d = s.GetMoneyGainedOnSelling(a, 12, 1);
    Console.WriteLine("The money gained on Selling the property in 1 year is " + d);


    Selling s1 = new Selling();
    double b = s1.GetMoneyLeft(720000, 560500, 3);
    double e = s1.GetMoneyGainedOnSelling(b, 12, 3);
    Console.WriteLine("The money gained on Selling the property in 3 years is " + e);

    Selling s2 = new Selling();
    double c = s2.GetMoneyLeft(720000, 560500, 3);
    double f = s2.GetMoneyGainedOnSelling(c, 12, 5);
    Console.WriteLine("The money gained on Selling the property in 5 years is " + f);
    double sellingbenefit = s2.moneygainedonselling;



    Owning o = new Owning();
    o.LessSaleCost(720000, 4, 3);
    o.MoneyGainedOnOwning(33319.2, 720000, 4, 560500, 1);
    Console.WriteLine("The money gained on Owning the property in 1 year is " + o.moneygainedonowning);

    Owning o1 = new Owning();
    o1.LessSaleCost(720000, 4, 3);
    o1.MoneyGainedOnOwning(33319.2, 720000, 4, 560500, 3);
    Console.WriteLine("The money gained on Owning the property in 3 years is " + o1.moneygainedonowning);

    Owning o2 = new Owning();
    o2.LessSaleCost(720000, 4, 3);
    o2.MoneyGainedOnOwning(33319.2, 720000, 4, 560500, 5);
    Console.WriteLine("The money gained on Owning the property in 5 years is " + o2.moneygainedonowning);
    double owningbenefit = o2.moneygainedonowning;

    if (sellingbenefit < owningbenefit)
    {
      Console.WriteLine("Hello Sandeep, Please own the property for benefit. Good Luck! ");
    }
    else
    {
      Console.WriteLine("Hello Sandeep, Please sell the property for benefit. Good Luck! ");

    }

  }


}
