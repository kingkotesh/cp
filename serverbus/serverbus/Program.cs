using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace serverbus
{
    [ServiceContract]
    interface IProblemSolver
    {
        [OperationContract]
        int Addition(int n1,  int n2);
    }
    class ProblemSolver : IProblemSolver
    {
        public int Addition(int n1,int n2)
        {
            return n1 + n2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh=new ServiceHost(typeof(ProblemSolver));
            sh.Open();
            Console.WriteLine("server started");
            Console.Read();
        }
    }
}
