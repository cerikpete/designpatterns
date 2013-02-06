namespace DuckLibrary.Command
{
    public class MoneyProcessor : ICommand
    {
        private readonly MoneyChanger moneyChanger;

        public MoneyProcessor(MoneyChanger moneyChanger)
        {
            this.moneyChanger = moneyChanger;
        }

        public string Execute()
        {
            return moneyChanger.ReceiveMoney();
        }
    }
}