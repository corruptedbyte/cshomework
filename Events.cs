using System.Timers;

namespace ConsoleApp6
{
    public delegate void RateChangedEventHandler(object sender, RateChangedEventArgs e);

    public class RateChangedEventArgs : EventArgs
    {
        public double Rate { get; }
        public RateChangedEventArgs(double rate) => Rate = rate;
    }

    class Trader
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double TraderMoneyDollars { get; set; }
        public double TraderMoneyHrivna { get; set; }

        public void OnRateChanged(object sender, RateChangedEventArgs e)
        {
            Console.WriteLine($"Rate changed to {e.Rate}. {FirstName} {LastName} is reacting.");
            if (e.Rate > 40)
            {
                BuyDollars(e.Rate);
            }
            else
            {
                SellDollars(e.Rate);
            }
        }

        private void BuyDollars(double rate)
        {
            double amountToBuy = TraderMoneyHrivna / rate;
            TraderMoneyDollars += amountToBuy;
            TraderMoneyHrivna -= amountToBuy * rate;
            Console.WriteLine($"{FirstName} {LastName} bought dollars. New balance: {TraderMoneyDollars}$, {TraderMoneyHrivna}hrn.");
        }

        private void SellDollars(double rate)
        {
            double amountToSell = TraderMoneyDollars;
            TraderMoneyHrivna += amountToSell * rate;
            TraderMoneyDollars = 0;
            Console.WriteLine($"{FirstName} {LastName} sold dollars. New balance: {TraderMoneyDollars}$, {TraderMoneyHrivna}hrn.");
        }
    }


    class Exchange
    {
        private double rate;
        private readonly Random random = new Random();
        private readonly System.Timers.Timer timer;

        public event RateChangedEventHandler RateChanged;

        public Exchange()
        {
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            rate = random.Next(30, 50) + random.NextDouble();
            OnRateChanged(new RateChangedEventArgs(rate));
        }

        protected virtual void OnRateChanged(RateChangedEventArgs e)
        {
            RateChanged?.Invoke(this, e);
        }
    }

}
