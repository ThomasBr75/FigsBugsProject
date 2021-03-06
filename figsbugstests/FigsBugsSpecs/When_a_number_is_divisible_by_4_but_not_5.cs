﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using FigsBugsProject;


namespace FigsBugsTests.FigsBugsSpecs
{


    [TestFixture]
    class When_a_number_is_divisible_by_4_but_not_5
    {
        private string _returnedValue;
        private FigsBugs _figsBugs = new FigsBugs();

        [TestFixtureSetUp]
        public void BeforeAll()
        {
            _returnedValue = _figsBugs.Print(4);
        }



        [Test]
        public void It_should_return_Extra()
        {
            Assert.AreEqual("Extra!", _returnedValue);
        }


    }
}
