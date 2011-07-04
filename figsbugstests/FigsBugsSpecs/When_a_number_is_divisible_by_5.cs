using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using FigsBugsProject;


namespace FigsBugsTests.FigsBugsSpecs
{

    [TestFixture]
    class When_a_number_is_divisible_by_5
    {

        string _returnedValue;
        FigsBugs _figsBugs = new FigsBugs();


        [TestFixtureSetUp]
        public void BeforeAll()
        {
            _returnedValue = _figsBugs.Print(5);
        }


        [Test]
        public void It_should_return_Bugs()
        {
            Assert.AreEqual("Bugs", _returnedValue);
        }

    }
}
