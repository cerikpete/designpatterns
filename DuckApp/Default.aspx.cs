using System;
using System.Collections.Generic;
using DuckLibrary;

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
            quackTheDucks.Click += quackTheDucks_Click;
        }

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

        }

        private void OutputData(List<IQuackable> ducksToQuack)
        {
            foreach (var duck in ducksToQuack)
            {
                output.Text += "<br />" + duck.Quack();
            }
        }
    }
}
