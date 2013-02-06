namespace DuckLibrary.Command
{
    /// <summary>
    /// Command object
    /// </summary>
    public class FoodDispenser : ICommand
    {
        private readonly IFoodProvider foodProvider;

        public FoodDispenser(IFoodProvider foodProvider)
        {
            this.foodProvider = foodProvider;
        }

        public string Execute()
        {
            return foodProvider.ProvideFood();
        }
    }
}