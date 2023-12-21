using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace kingservice
{
    [ServiceContract]
    interface IProblemSolver
    {
        [OperationContract]
        int product(int a, int b);
    }
    class ProblemSolver : IProblemSolver
    {
        public int product(int a, int b)
        {
            return a * b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceHost s=new ServiceHost(typeof(ProblemSolver));
            s.Open();
            Console.WriteLine("server started");
            Console.Read();
            s.Close();
        }
    }
}
