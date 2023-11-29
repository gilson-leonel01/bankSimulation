namespace bankSimulation.Properties.Classes
{
    public class CurrentAccount : Account
    {
        public CurrentAccount()
        {
            this.AccountNumber = "00" + Account.AcountNumberSequency;
        }
    }
}