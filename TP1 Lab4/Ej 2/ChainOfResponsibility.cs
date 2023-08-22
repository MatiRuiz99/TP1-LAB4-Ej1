using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Lab4.Ej_2
{
    using System;

    
    interface IRequestHandler
    {
        void Approve(Request request);
    }

    
    class Manager : IRequestHandler
    {
        public void Approve(Request request)
        {
            if (request.Amount <= 1000)
            {
                Console.WriteLine($"Manager approves request for {request.Amount:C}");
            }
        }
    }

    class Director : IRequestHandler
    {
        public void Approve(Request request)
        {
            if (request.Amount <= 5000)
            {
                Console.WriteLine($"Director approves request for {request.Amount:C}");
            }
        }
    }

    class CEO : IRequestHandler
    {
        public void Approve(Request request)
        {
            if (request.Amount <= 10000)
            {
                Console.WriteLine($"CEO approves request for {request.Amount:C}");
            }
        }
    }

    // Request
    class Request
    {
        public decimal Amount { get; }

        public Request(decimal amount)
        {
            Amount = amount;
        }
    }

    

}
