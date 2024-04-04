using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RPS
    {
        public Uri Path { get; private set; }
        public int Value { get; private set; }
        public RPS(int val) {
            Value = val;
            if (Value == 0)
                Path = new Uri("F:\\Проекты\\С#\\RockPaperScissors\\RockPaperScissors\\Resourses\\rc.png");
            if (Value == 1)
                Path = new Uri("F:\\Проекты\\С#\\RockPaperScissors\\RockPaperScissors\\Resourses\\pp.png");
            if (Value == 2)
                Path = new Uri("F:\\Проекты\\С#\\RockPaperScissors\\RockPaperScissors\\Resourses\\sc.png");
        }
    }
}
