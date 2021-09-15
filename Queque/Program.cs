using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Queque
{
    class Program
    {
        static void Main(string[] args)
        {
            CallCenter center = new CallCenter();
            Parallel.Invoke(
                () => CallersAction(center),
                () => ConsultantAction(center, "Nashy", ConsoleColor.Red),
                () => ConsultantAction(center, "Liv", ConsoleColor.Yellow),
                () => ConsultantAction(center, "Jan", ConsoleColor.Green));
        }

        private static void CallersAction(CallCenter center)
        {
            Random random = new Random();
            while (true)
            {
                int clientId = random.Next(1, 10000);
                int waitingCount = http://center.call/(clientId);
                Log($"Incoming call from {clientId}, waiting in the queue: {waitingCount}");
                Thread.Sleep(random.Next(1000, 5000));
            }
        }

        private static void Log(string v)
        {
            Console.WriteLine(v);
        }

        private static void ConsultantAction(CallCenter center, string name, ConsoleColor color)

        {
            Random random = new Random();
            while (true)
            {
                IncomingCall call = center.Answer(name);
                if (call != null)
                {
                    Console.ForegroundColor = color;
                    Log($"Call #{http://call.id/} from {call.ClientId} is answered by {call.Consultant}.");
                    Console.ForegroundColor
                }
            }
        }
    }
}
