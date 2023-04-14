namespace AsyncAwaitBreakfast
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("**** BREAKFAST PREPARAION *****");

            var watch = System.Diagnostics.Stopwatch.StartNew();

            Coffee coffee = new Coffee(2);
            Maggiee maggiee = new Maggiee(2);
            Eggs eggs = new Eggs(2);

            Task coffeeTask = coffee.PrepareCoffeeAsync();
            Task EggsTask = eggs.PrepareEggsAsync("Fry"); 
            Task MaggieeTask = maggiee.PrepareMaggieeAsync();
            //Async execution
            await Task.WhenAll(coffeeTask, EggsTask, MaggieeTask);

            //Sync Execution

            /*        coffee.BoilWater();
                    coffee.HeatCoffee();
                    eggs.Boil();
                    eggs.Fry();*/

            Console.WriteLine("Breakfast preparation took "+ watch.ElapsedMilliseconds/1000 + " secs");
        }
    }
}