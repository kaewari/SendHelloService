using System;

namespace CalculateService
{
    class SendConsole : INotification
    {
        public void Notify(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
