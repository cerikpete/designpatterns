using System;
using System.Collections.Generic;
using DuckLibrary;
using DuckLibrary.Aggregates;
using DuckLibrary.BarnAutomation;
using DuckLibrary.Decorators;
using DuckLibrary.Ducks;
using DuckLibrary.Factories;
using DuckLibrary.Logging;
using DuckLibrary.Observers;
using DuckLibrary.OtherBirds;
using DuckLibrary.Sorter;
using Geese;

namespace DuckApp
{
    public partial class _Default : System.Web.UI.Page
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            WireUpEvents();
        }

        private void WireUpEvents()
        {
            sortTheDucks.Click += sortTheDucks_Click;
            quackTheDucks.Click += quackTheDucks_Click;
            countTheDucks.Click += countTheDucks_Click;
            generateNormalDucks.Click += generateNormalDucks_Click;
            generateCountableDucks.Click += generateCountableDucks_Click;
            iterateMyDucks.Click += iterateMyDucks_Click;
            flyTheDucks.Click += flyTheDucks_Click;
            manageTheBarn.Click += manageTheBarn_Click;
            observeTheDucks.Click += observeTheDucks_Click;
            logTheDucks.Click += logTheDucks_Click;
        }

        // Static gateway pattern
        void logTheDucks_Click(object sender, EventArgs e)
        {
            LogTheBirds();
            //LogTheBirdsGenerically();
            //LogTheBirdsWithExtensionMethods();
        }

        private void LogTheBirds()
        {
            Logger.For(typeof(Duck)).WriteMessage("Logging a duck");
            Logger.For(typeof(Goose)).WriteMessage("Logging a goose");

            Console.WriteLine("Check the log");
        }

        private void LogTheBirdsGenerically()
        {
            Duck duck = new Duck();

            GenericLogger.For(duck).WriteMessage("Logging a duck generically");
            GenericLogger.For<Goose>().WriteMessage("Logging a goose generically");
        }

        private void LogTheBirdsWithExtensionMethods()
        {
            Duck duck = new Duck();
            duck.Log("Logging the duck using extension methods");
        }

        // Strategy pattern
        void sortTheDucks_Click(object sender, EventArgs e)
        {
            SortDucks();
            //SortDucksInMoreGenericFashion();
        }

        // Observer pattern
        void observeTheDucks_Click(object sender, EventArgs e)
        {
            ShiftManager shiftManager = new ShiftManager();
            UptightDuck uptightDuck = new UptightDuck();
            PartyAnimalDuck partyAnimalDuck = new PartyAnimalDuck();
            shiftManager.RegisterObserver(uptightDuck);
            shiftManager.RegisterObserver(partyAnimalDuck);

            shiftManager.ChangeFarmer(new FarmerBill());
            shiftManager.ChangeFarmer(new FarmerFred());
        }

        // Command pattern
        void manageTheBarn_Click(object sender, EventArgs e)
        {
            var barnManager = new BarnManager(new BarnAutomatorFactory());
            barnManager.ManageTheBarn();
        }

        // Code using the template method pattern
        void flyTheDucks_Click(object sender, EventArgs e)
        {
            Duck mallard = new MallardDuck();
            mallard.Migrate();

            Duck mandarin = new MandarinDuck();
            mandarin.Migrate();
        }

        // Iterator pattern with aggregate
        void iterateMyDucks_Click(object sender, EventArgs e)
        {
            DuckFlock flock = new DuckFlock();
            flock.Add(new MallardDuck());
            flock.Add(new MandarinDuck());
            flock.Add(new RubberDuck());
            LoopThroughDucksUsingIterator(flock);
        }

        // Abstract factory pattern
        void generateCountableDucks_Click(object sender, EventArgs e)
        {
            GenerateListOfDucksFromFactory(new CountableDuckFactory());
        }

        // Abstract factory pattern
        void generateNormalDucks_Click(object sender, EventArgs e)
        {
            GenerateListOfDucksFromFactory(new DuckFactory());
        }

        private void GenerateListOfDucksFromFactory(AbstractDuckFactory duckFactory)
        {
            QuackCounter.ResetQuacks();

            IQuackable duck1 = duckFactory.CreateMallardDuck();
            IQuackable duck2 = duckFactory.CreateRubberDuck();
            List<IQuackable> factoryDucks = new List<IQuackable> { duck1, duck2 };
            OutputData(factoryDucks);
            Console.WriteLine("Number of quacks: " + QuackCounter.GetNumberOfQuacks());
        }

        // Decorator pattern
        void countTheDucks_Click(object sender, EventArgs e)
        {
            QuackCounter.ResetQuacks();

            // An example of the decorator pattern
            List<IQuackable> ducksToCount = new List<IQuackable>();
            IQuackable mallardDuck = new QuackCounter(new MallardDuck());
            IQuackable rubberDuck = new QuackCounter(new RubberDuck());
            IQuackable decoy = new DuckDecoy();
            ducksToCount.Add(mallardDuck);
            ducksToCount.Add(rubberDuck);
            ducksToCount.Add(decoy);
            OutputData(ducksToCount);
            Console.WriteLine("Number of quacks: " + QuackCounter.GetNumberOfQuacks());
        }

        // Adapter pattern
        void quackTheDucks_Click(object sender, EventArgs e)
        {
            List<IQuackable> ducksToQuack = new List<IQuackable>();

            // Let's create some ducks - shows the beauty of interfaces
            MallardDuck mallardDuck = new MallardDuck();
            ducksToQuack.Add(mallardDuck);
            RubberDuck rubberDuck = new RubberDuck();
            ducksToQuack.Add(rubberDuck);
            DuckDecoy duckDecoy = new DuckDecoy();
            ducksToQuack.Add(duckDecoy);

            // Add a goose adapter to show the adapter pattern
            Goose goose = new Goose();
            GooseToDuckAdapter gooseToDuckAdapter = new GooseToDuckAdapter(goose);
            ducksToQuack.Add(gooseToDuckAdapter);
            
            OutputData(ducksToQuack);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            output.Text = String.Empty;
            Console.SetOut(new CustomTextWriter(output));
        }

        private void OutputData(List<IQuackable> ducksToQuack)
        {
            foreach (var duck in ducksToQuack)
            {
                duck.Quack();
            }
        }

        private void LoopThroughDucksUsingIterator(DuckFlock flock)
        {
            IIterator<IQuackable> duckIterator = new DuckIterator(flock);
            IQuackable currentDuck = duckIterator.Current();
            while (currentDuck != null)
            {
                currentDuck.Quack();
                currentDuck = duckIterator.Next();  
            }
        }

        private void SortDucks()
        {
            DuckFlock flock = CreateTestFlock();

            flock.SortWith(new NameSorter(flock));
            PrintSortedDucks(flock.Ducks);

            flock.SortWith(new TypeSorter(flock));
            PrintSortedDucks(flock.Ducks);
        }

        private void SortDucksInMoreGenericFashion()
        {
            DuckFlock flock = CreateTestFlock();

            IGenericSorter<IQuackable> sortByName = new GenericDuckSorter(flock);
            sortByName.SortFlockBy(x => x.Name);
            PrintSortedDucks(flock.Ducks);

            IGenericSorter<IQuackable> sortByType = new GenericDuckSorter(flock);
            sortByType.SortFlockBy(x => x.GetType());
            PrintSortedDucks(flock.Ducks);   
        }

        private DuckFlock CreateTestFlock()
        {
            DuckFlock flock = new DuckFlock();
            flock.Add(new MallardDuck { Name = "Fred the Mallard" });
            flock.Add(new MandarinDuck { Name = "Aaron the Mandarin" });
            return flock;
        }

        private void PrintSortedDucks(List<IQuackable> sortedDucks)
        {
            foreach (var duck in sortedDucks)
            {
                Console.WriteLine(string.Format("Type: {0} - Name: {1}", duck.GetType(), duck.Name));
            }
        }
    }
}
