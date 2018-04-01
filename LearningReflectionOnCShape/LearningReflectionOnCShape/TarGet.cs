using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningReflectionOnCShape
{
    public class Target
    {
        private string name = "taro";

        public string ideorogy = "cear";

        private readonly int age = 34;

        private Action say = () => Console.WriteLine("hello my nami is taro");

        public string Naem { get => name; set => name = value; }

        public int Age => age;

        public Action Say { get => say; set => say = value; }
    }
}
