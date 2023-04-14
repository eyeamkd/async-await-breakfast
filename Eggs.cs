namespace AsyncAwaitBreakfast
{
    public class Eggs
    {
        public int count { get; set; }

        public Eggs(int count)
        {
            this.count = count;
        }

        public void Fry()
        {
            Console.WriteLine("Frying " + this.count + " Eggs");
            Task.Delay(1000 * this.count).Wait();
            Console.WriteLine("Frying Completed");
        }

        public void Boil()
        {
            Console.WriteLine("Boiling " + this.count + " Eggs");
            Task.Delay(1000 * this.count).Wait();
            Console.WriteLine("Frying Completed");
        }

        public async Task FryAsync()
        {
            Console.WriteLine("Frying " + this.count + " Eggs");
            await Task.Delay(1000 * this.count);
            Console.WriteLine("Frying Completed");
        }

        public async Task BoilAsync()
        {
            Console.WriteLine("Boiling " + this.count + "Eggs");
            await Task.Delay(1000* this.count);
            Console.WriteLine("Boiling Completed");
        }

        public async Task PrepareEggsAsync(string type)
        {
            if(type == "Fry")
                await FryAsync();
            else
                await BoilAsync();
        }
    }
}
