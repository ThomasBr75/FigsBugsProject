using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using FigsBugsProject;


namespace FigsBugsTests.FigsBugsSpecs
{

    [TestFixture]
    class When_run_100_times
    {

        string _returnedValue;
        FigsBugs _figsBugs = new FigsBugs();
        List<string> _returnedValues = new List<string>();


        [TestFixtureSetUp]
        public void BeforeAll()
        {
            for (int i = 1; i < 101; i++)
            {
                _returnedValue = _figsBugs.Print(i);
                _returnedValues.Add(_returnedValue);
                Console.WriteLine(_returnedValue);
            }
        }

        [Test]
        public void A_100_strings_should_be_printed()
        {
            Assert.AreEqual(100, _returnedValues.Count); 
        }

    }
}
