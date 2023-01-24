using Comms.Models;

namespace Comms
{
    public class Exercise1 
    {
        static void Main(string[] args)
        {
            SimCard simCard01 = new SimCard("09072833111", "Smart");
            SimCard simCard02 = new SimCard("09752599371", "Globe");

            MobilePhone mobilePhone01 = new MobilePhone("Apple", "Alpine Green", "iPhone 13 Pro Max", simCard01);
            MobilePhone mobilePhone02 = new MobilePhone("Google", "Hazel", "Pixel 7 Pro", simCard02);

            mobilePhone01.Call(mobilePhone02.GetPhoneNumber());

            SmartPhone smartPhone01 = new SmartPhone("Apple", "Sierra Blue", "iPhone 13", simCard01, "Opera Mini");
            SmartPhone smartPhone02 = new SmartPhone("Google", "Obsidian Black", "Pixel 7", simCard02, "Chrome");

            smartPhone02.Call(smartPhone01.GetPhoneNumber());

            App app01 = new App("Facebook", 74f);
            App app02 = new App("Instagram", 63f);

            smartPhone01.AddApplication(app01);
            smartPhone01.AddApplication(app01);

            Console.WriteLine("Total Size of Applications in smartPhone01: " + smartPhone01.GetTotalSize() + " MB");

        }
    }
}
