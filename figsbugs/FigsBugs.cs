using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FigsBugsProject
{
    public class FigsBugs
    {
        int _number;

        public string Print(int number)
        {
            _number = number;
            if (DivisibleBy5ButNot3())
                return "Bugs";
            if (DivisibleBy3And5())
                return "FigsBugs";
            if (DivisibleBy3ButNot5())
                return "Figs";
            return _number.ToString();
        }

        private bool DivisibleBy3And5()
        {
            return ((_number % 3 == 0) && (_number % 5 == 0));
        }

        private bool DivisibleBy5ButNot3()
        {
            return ((_number % 5 == 0) && (_number % 3 != 0)); 
        }

        private bool DivisibleBy3ButNot5()
        {
            return ((_number % 5 != 0) && (_number % 3 == 0));
        }

    }
}
