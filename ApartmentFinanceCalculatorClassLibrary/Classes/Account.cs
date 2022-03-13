namespace ApartmentFinanceCalculatorClassLibrary.Classes
{
    public class Account
    {
        // Properties
        public string AccountHolder {get; private set;}
        public double AmmountPaid {get; set;} = 0;

        // Constructor
        public Account(string accountHolderName)
        {
            AccountHolder = accountHolderName;
        }
    }
}