using System;

    class Program
    {
        static void Main()
        {
            double tomatoePrice = 0.5;
            double cucumberPrice = 0.4;
            double potatoePrice = 0.25;
            double carrotPrice = 0.6;
            double cabbagePrice = 0.3;
            double beansPrice = 0.4;

            int totalArea = 250;

            int tomatoeAmount = int.Parse(Console.ReadLine());
            int tomatoeArea = int.Parse(Console.ReadLine());
            int cucumberAmount = int.Parse(Console.ReadLine());
            int cucumberArea = int.Parse(Console.ReadLine());
            int potatoeAmount = int.Parse(Console.ReadLine());
            int potatoeArea = int.Parse(Console.ReadLine());
            int carrotAmount = int.Parse(Console.ReadLine());
            int carrotArea = int.Parse(Console.ReadLine());
            int cabbageAmount = int.Parse(Console.ReadLine());
            int cabageArea = int.Parse(Console.ReadLine());
            int beansAmount = int.Parse(Console.ReadLine());

            double totalCosts = (tomatoePrice * tomatoeAmount) + (cucumberPrice * cucumberAmount) + (potatoePrice * potatoeAmount) +
                (carrotPrice * carrotAmount) + (cabbagePrice * cabbageAmount) + (beansPrice * beansAmount);

            int areaWithoutbeans = tomatoeArea + cucumberArea + potatoeArea + carrotArea + cabageArea;
            int beansArea = totalArea - areaWithoutbeans;

            if (beansArea>0)
            {
                Console.WriteLine("Total costs: {0:0.00}", totalCosts);
                Console.WriteLine("Beans area: {0}", beansArea);    
            }
            else if (beansArea < 0)
            {
                Console.WriteLine("Total costs: {0:0.00}", totalCosts);
                Console.WriteLine("Insufficient area");  
            }
            else
            {
                Console.WriteLine("Total costs: {0:0.00}", totalCosts);
                Console.WriteLine("No area for beans");  
            }
        }
    }

