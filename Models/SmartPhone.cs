namespace Comms.Models
{
    public class SmartPhone : MobilePhone
    {
        public string browser {get; set;}
        public List<App> applications {get; set;}

        public SmartPhone(string phoneBrand, string phoneColor, string phoneModel, SimCard simCard, string phoneBrowser)
            : base(phoneBrand, phoneColor, phoneModel, simCard)
            {
                this.browser = phoneBrowser;
                this.applications = new List<App>();
            }
            
        public void CallFromBrowser(string phoneNumber)
        {
            Console.WriteLine("Calling from " + browser);
            base.Call(phoneNumber);
        }

        public void CallFromBrowser(MobilePhone mobilePhone)
        {
            Console.WriteLine("Calling from " + browser);
            base.Call(mobilePhone);
        }

        public void AddApplication(App app)
        {
            this.applications.Add(app);
        }

        public float GetTotalSize()
        {
            float totalAppSize = 0;
            foreach (App app in applications)
            {
                totalAppSize += app.size;
            }
            return totalAppSize;
        }
    }
}