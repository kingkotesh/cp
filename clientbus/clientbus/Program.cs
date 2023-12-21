using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Microsoft.Identity.Client;
namespace clientbus
{
    [ServiceContract]
    interface IProblemSolver
    {
        [OperationContract]
        int Addition(int n1,int n2);
    }
    interface IProblemSolverChannel : IProblemSolver, IClientChannel { }
    class Program
    {
        static void Main(string[] args)
        {
            var c = new ChannelFactory<IProblemSolverChannel>("solverEP");
            var ch=c.CreateChannel();
            Console.WriteLine(ch.Addition(1, 2));
            Console.Read();
        }
    }
}
