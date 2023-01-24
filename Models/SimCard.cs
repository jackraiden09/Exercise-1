namespace Comms.Models
{
    public class SimCard
    {
        public string phoneNumber {get; set;}
        public string network {get; set;}

        public SimCard(string phoneNum, string net)
        {
            this.phoneNumber = phoneNum;
            this.network = net;
        }
    }

}