namespace Comms.Models 
{
    public class App 
    {
        public string name {get; set;}
        public float size {get; set;}

        public App(string appName, float appSize)
        {
            this.name = appName;
            this.size = appSize;
        }
    }
}