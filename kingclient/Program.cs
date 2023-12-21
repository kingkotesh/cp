using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace kingclient
{
    [ServiceContract]
    interface IProblemSolver
    {
        [OperationContract]
        int product(int a,int b);
    }
    interface IProblemSolverChannel : IProblemSolver, IClientChannel { }
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new ChannelFactory<IProblemSolverChannel>("solverEP");
            var ch=c.CreateChannel();
            Console.WriteLine(ch.product(2, 3));
            Console.Read();
            //ch.Close();
        }
    }
}
