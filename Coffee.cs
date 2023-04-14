namespace AsyncAwaitBreakfast
{
    public class Coffee
    {
        public int cups { get; set; }

        public Coffee(int cups)
        { this.cups = cups; }

        public void BoilWater()
        {
            Console.WriteLine("Starting to boil water for coffee");
            Task.Delay(1000 * cups).Wait();
            Console.WriteLine("Boiling Water Completed");
        }

        public async Task BoilWaterAsync()
        {
            Console.WriteLine("Starting to boil water for coffee");
            await Task.Delay(1000 * cups);
            Console.WriteLine("Completed Boiling Water!");
        }

        public void HeatCoffee()
        {
            Console.WriteLine("Heating Coffee...");
            Task.Delay(2000 * cups).Wait();
            Console.WriteLine("Coffee Completed");
        }

        public async Task HeatCoffeeAsync()
        {
            Console.WriteLine("Heating Coffee..");
            await Task.Delay(2000 * cups);
            Console.WriteLine("Heating Coffee Completed");

        }

        public async Task PrepareCoffeeAsync()
        {
            Console.WriteLine("Preparing Coffee");
            await BoilWaterAsync();
            await HeatCoffeeAsync();    
            Console.WriteLine("Preparing Coffee Completed");
        }
    }
}
