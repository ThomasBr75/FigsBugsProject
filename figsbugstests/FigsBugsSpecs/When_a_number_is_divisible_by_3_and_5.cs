using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using FigsBugsProject;



namespace FigsBugsTests.FigsBugsSpecs
{
    
    [TestFixture]
    class When_a_number_is_divisible_by_3_and_5
    {
        string _returnedValue;
        FigsBugs _figsBugs = new FigsBugs();

        [TestFixtureSetUp]
        public void BeforeAll()
        {
            _returnedValue = _figsBugs.Print(15);
        }

        [Test]
        public void It_should_return_FigsBugs()
        {
            Assert.AreEqual("FigsBugs", _returnedValue);
        }

    }
}
