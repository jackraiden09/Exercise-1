using Comms.Models;

namespace Comms
{
    public class Exercise1 
    {
        static void Main(string[] args)
        {
            SimCard simCard01 = new SimCard("09072833111", "Smart");
            SimCard simCard02 = new SimCard("09752599371", "Globe");

            MobilePhone mobilePhone01 = new MobilePhone("iPhone", "Midnight Blue", "13 Pro Max", simCard01);
            MobilePhone mobilePhone02 = new MobilePhone("Google", "Obsidian Black", "Pixel 7 Pro", simCard02);

            SmartPhone smartPhone01 = new SmartPhone("iPhone", "Midnight Blue", "13 Pro Max", simCard01, "Safari");
            SmartPhone smartPhone02 = new SmartPhone("Google", "Obsidian Black", "Pixe 7 Pro", simCard02, "Chrome");

            mobilePhone01.Call(mobilePhone02.GetPhoneNumber());
            smartPhone01.Call(smartPhone02.GetPhoneNumber());

            App app01 = new App("Facebook", 74f);
            App app02 = new App("Instagram", 63f);

            Console.WriteLine("Total Size of Applications in smartPhone01: " + smartPhone01.GetTotalSize() + " MB");

            Console.WriteLine("Total Size of Applications in smartPhone02: " + smartPhone02.GetTotalSize() + " MB");

        }
    }
}
