using bankSimulation.Properties.Contract;

namespace bankSimulation.Properties.Classes
{
    public abstract class Account : Bank, IAccount
    {
        public Account()
        {
            this.AccountNumber = "001";
            Account.AcountNumberSequency++;
        }
        
        public double Balance { get; protected set; }
        public string AgencyNumber { get; private set; }
        public string AccountNumber { get; protected set; }
        public static int AcountNumberSequency { get; private set; }
        
        public void deposit(double amount)
        {
            this.Balance += amount;
        }

        public bool raise(double amount)
        {
            if (amount > this.ConsultBalance()) //this.Balance
                return false;
            
            this.Balance -= amount;
            return true;
        }

        public double ConsultBalance()
        {
            return this.Balance;
        }

        public string GetPinAccess()
        {
            return this.BankCode;
        }

        public string GetAgencyNumber()
        {
            return this.AgencyNumber;
        }

        public string GetAccountNumber()
        {
            return this.AccountNumber;
        }
    }
}