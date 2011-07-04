using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using FigsBugsProject;


namespace FigsBugsTests.FigsBugsSpecs
{
       

    [TestFixture]
    class When_number_is_divisible_by_3
    {
        FigsBugs _figsBugs = new FigsBugs();
        string _returnedValue;

        [TestFixtureSetUp]
        public void BeforeAll()
        {
            _returnedValue = _figsBugs.Print(3);
        }

        [Test]
        public void It_should_return_Figs()
        {
            Assert.AreEqual("Figs", _returnedValue);
        }

    }
}
