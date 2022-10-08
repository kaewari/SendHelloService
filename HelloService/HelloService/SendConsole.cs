using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloService
{
    class SendConsole : INotification
    {
        public void Notify(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
