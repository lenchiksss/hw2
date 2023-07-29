public class Money
{
    public int dollars;
    public int cents;

    public Money(int dollars, int cents)
    {
        this.dollars = dollars;
        this.cents = cents;
    }

    public void SetMoney(int dollars, int cents)
    {
        if (dollars >= 0 && cents >= 0 && cents < 100)
        {
            this.dollars = dollars;
            this.cents = cents;
        }
        else
        {
            Console.WriteLine("Некоректна сума грошей. Введені значення повинні бути не від'ємними, а копійок має бути не більше 100.");
        }
    }

    public void Display()
    {
        Console.WriteLine($"Введена сума: {dollars} доларів {cents} центів");
    }
}

public class Product : Money
{
    public Product(int dollars, int cents) : base(dollars, cents)
    {

    }

    public new void ChangePrice(int dollars, int cents)
    {
        if (dollars >= 0 && cents >= 0 && cents < 100)
        {
            base.SetMoney(dollars, cents);
        }
        else
        {
            Console.WriteLine("Некоректна ціна продукту. Введені значення повинні бути не від'ємними, а копійок має бути не більше 100.");
        }
    }
}