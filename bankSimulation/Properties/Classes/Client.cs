namespace bankSimulation.Properties.Contract
{
    public class Client
    {
        public string Name { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Passcode { get; private set; }
        
        public IAccount Account { get; set; }

        public void SetName(string name)
        {
            this.Name = name;
        }
        
        public void SetPhoneNumber(string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
        }
        
        public void SetPasscode(string passcode)
        {
            this.Passcode = passcode;
        }
    }
}