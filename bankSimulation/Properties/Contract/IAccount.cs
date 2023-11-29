namespace bankSimulation.Properties.Contract
{
    public interface IAccount
    {
        void deposit(double amount);
        bool raise(double amount);
        
        double ConsultBalance();
        string GetPinAccess();
        string GetAgencyNumber();
        string GetAccountNumber();
    }
}