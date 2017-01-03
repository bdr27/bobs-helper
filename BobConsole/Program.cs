using BobsHelper.BForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            BNotificationBubble form = new BNotificationBubble();
            form.Show();
            Console.ReadKey();
        }
    }
}
