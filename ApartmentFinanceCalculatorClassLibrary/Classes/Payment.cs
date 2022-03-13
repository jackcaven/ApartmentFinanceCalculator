namespace ApartmentFinanceCalculatorClassLibrary.Classes
{
    public class Payment
    {
        // Properties
        public Account From {get; set;}
        public Account To {get; set;}
        public double Amount {get; set;}

        public Payment(Account from, Account to, double amount)
        {
            if(!IsAmountPaidPositive(amount))
            {
                throw new exception("Amount paid must be positive");
            }

            From = from;
            To = to;
            Amount = amount;
        }

        private bool IsAmountPaidPositive(double amount)
        {
            return amount > 0;
        }
    }
}