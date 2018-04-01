using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningReflectionOnCShape
{
    class Program
    {
        static void Main(string[] args)
        {
            const string path = @"C:\Users\yamam\Source\Repos\LearningGenric\LearningGenric\Target.txt";

            Target target = new Target();

            Generic<Target> generic = new Generic<Target>(target, path);

            generic.Save();

            Console.WriteLine("end");
            Console.ReadKey();
        }
    }
}
