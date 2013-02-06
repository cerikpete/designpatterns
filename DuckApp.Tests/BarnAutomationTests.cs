using DuckLibrary.BarnAutomation;
using NUnit.Framework;

namespace DuckApp.Tests
{
    [TestFixture]
    public class BarnAutomationTests
    {
        private BarnManager barnManager;

        [SetUp]
        public void Setup()
        {
            barnManager = new BarnManager(new BarnAutomatorFactory());
        }

        [Test]
        public void Should_perform_morning_noon_and_night_tasks()
        {
            barnManager.ManageTheBarn();
        }
        
    }
}
