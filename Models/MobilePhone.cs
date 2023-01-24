namespace Comms.Models
{
    public class MobilePhone
    {
        public string brand { get; set; }
        public string color { get; set; }
        public string model { get; set; }
        public SimCard simCard { get; set; }

        public MobilePhone(string phoneBrand, string phoneColor, string phoneModel, SimCard simCard)
        {
            this.brand = phoneBrand;
            this.color = phoneColor;
            this.model = phoneModel;
            this.simCard = simCard;
        }

        public string GetPhoneNumber()
        {
            return simCard.phoneNumber;
        }

        public void SwapSimCard(SimCard simCard)
        {
            this.simCard = simCard;
        }

        public void Call(string phoneNumber)
        {
            Console.WriteLine("Calling " + phoneNumber + " from number " + GetPhoneNumber());
        }

        public void Call(MobilePhone mobilePhone)
        {
            Console.WriteLine("Calling " + mobilePhone.GetPhoneNumber() + " from number " + GetPhoneNumber());
        }
    }

}
