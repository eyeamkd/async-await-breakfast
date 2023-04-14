namespace AsyncAwaitBreakfast
{
    public class Maggiee
    {
        public int cakeCount { get; set; }

        public Maggiee(int cakeCount)
        {
            this.cakeCount = cakeCount;
        }
        private void BoilWater()
        {
            Console.WriteLine("Staring to boil water...");
            Task.Delay(1000 * cakeCount).Wait();
            Console.WriteLine("Boiling Water Completed");
        }

        public void CookMaggiee()
        {
            this.BoilWater();
            Console.WriteLine("Starting to cook maggiee...");
            Task.Delay(1000 * cakeCount).Wait();
            Console.WriteLine("Maggiee Cooked");
        }

        private async Task BoilWaterAsync()
        {
            Console.WriteLine("Staring to boil water...");
            await Task.Delay(1000 * cakeCount);
            Console.WriteLine("Boiling Water Completed");
        }

        public async Task PrepareMaggieeAsync()
        {
            await BoilWaterAsync();
            Console.WriteLine("Starting to cook maggiee...");
            await Task.Delay(1000 * cakeCount);
            Console.WriteLine("Maggiee Cooked");
        }

    }
}
