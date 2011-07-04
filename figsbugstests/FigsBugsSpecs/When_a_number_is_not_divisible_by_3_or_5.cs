using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using FigsBugsProject;

namespace FizzBuzzTests.FigsBugsSpecs
{

    [TestFixture]
    class When_a_number_is_not_divisible_by_3_or_5
    {
        string _returnedValue;
        FigsBugs _figsBugs = new FigsBugs();

        [TestFixtureSetUp]
        public void BeforeAll()
        {
            _returnedValue = _figsBugs.Print(17);
        }

        [Test]
        public void It_should_return_the_actual_number()
        {
            Assert.AreEqual("17", _returnedValue);
        }

    }
}
