using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Security.Cryptography;

namespace Defining___Classes___part_1__HW
{
    //Define a class that holds information about a mobile phone device: 
    //model, manufacturer, price, owner, battery characteristics 
    //(model, hours idle and hours talk) and display characteristics (size and number of colors).
    class GSM
    {
        private string model;
        private string manufacturer;
        private double? price;
        private string owner;
        private Battery battery = new Battery();
        private Display display = new Display();

       // Problem 5: Encapsulate all data fields
        public string Model// pravim property za da moje da se izvikva i da e dostupno
        {
            get {return model;}
            set
            {                
                if(value.Length == 0)
                {throw new ArgumentException("You must enter Model.");}
                else
                {this.model = value; }
            }
        }

        public string Manufacturer// drygo property
        {
            get { return manufacturer; }
            set
            {
                if (value.Length == 0)
                { throw new ArgumentException("You must enter Manifacturer."); }
                else
                { this.model = value; }
            }
        }
        
        public double? Price      // moje da e NULL
        {
            get { return price; }
            set
            {
                if (value < 0)
                { throw new ArgumentException("Price must be greater or equal ZERO."); }
                else
                { this.price = value; }
            }
        }

        public string Owner
        {
            get { return owner; }
            set
            {
                if (value.Length == 0)
                { throw new ArgumentException("You must enter Manifacturer."); }
                else
                { this.owner = value; }

            }
        }
        public Battery Battery
        {
            get { return battery; }
            set { this.battery = value; }
        }
        public Display Display
        {
            get { return display; }
            set { this.display = value; }
        }
        //Problem 2: Define constructors for the GSM,
        public GSM()//default constuctor that is empty
        {
            this.model = null;
            this.manufacturer = null;
            this.price = null;
            this.owner = null;
            this.battery = null;
            this.display = null;
        }
        public GSM(string model, string manufacturer, double price, string owner, 
            Battery battery, Display display): this() // full constructor null, also available
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }
        //Problem 4: Override the ToString() method
        public override string ToString()
        {
            StringBuilder gsmInfo = new StringBuilder();
            gsmInfo.AppendFormat("Model: {0}\n", this.model);
            gsmInfo.AppendFormat("Manufacturer: {0}\n", this.manufacturer);
            gsmInfo.AppendFormat("Price: {0}\n", this.price);
            gsmInfo.AppendFormat("Owner: {0}\n", this.owner);
            gsmInfo.AppendFormat("Battery Model: {0}\n", this.Battery.Model);
            gsmInfo.AppendFormat("Battery Idle Hours: {0}\n", this.Battery.HoursIdle);
            gsmInfo.AppendFormat("Battery Idle Talk: {0}\n", this.Battery.HoursTalk);
            gsmInfo.AppendFormat("Display Size: {0}\n", this.Display.Size);
            gsmInfo.AppendFormat("Display colors: {0}\n", this.Display.Colors);

            return gsmInfo.ToString();// to string zaradi string buildera ne za drygo
        }
        public static GSM iPhone4S = new GSM("IPhone4S", "Apple", 900, "BLaa",// generate something absoluteli fixed
            new Battery("LiIon", 20, 5), new Display(4, 160000000));

        public GSM IPhone4S
        {
            get { return GSM.iPhone4S; }
            private set { }// da ne se promqna nokoga
        }


        //Problem 9: Create list of calls history

        private List<Call> callHistory = new List<Call>();
        public List<Call> CallHistory
        {
            get { return callHistory; }
            set { this.callHistory = value; }
        }
        //Problem 10: Add, delete, clear calls history 
        public void AddCalls ( Call callCurrent)
        {
           this.callHistory.Add(callCurrent);
        }
        public void RemoveCall(Call callToRemove)
        {
            this.callHistory.Remove(callToRemove);
        }
        public void ClearHistory()
        {
           this.callHistory.Clear();
        }
        public double PriceCalc (double pricePerMinute)
        {
            double totalminutes = 0;

            foreach (var calls in callHistory)
            {
                totalminutes +=(double) calls.Duration/60;
            }         
            double totalprice = (double)totalminutes*pricePerMinute;
            return totalprice;
        }


    }
}
