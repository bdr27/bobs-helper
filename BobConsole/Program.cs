using BobsHelper.BForm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BobConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread mThread = new Thread(delegate ()
            //{

                TestForm form = new TestForm();
                form.ShowDialog();
            //    Console.WriteLine("Hello WOrld");
            //});
            //mThread.SetApartmentState(ApartmentState.STA);
            //mThread.IsBackground = true;
            //mThread.Start();
            //BNotificationBubble form = new BNotificationBubble("Sup World");
            //form.Show();
            Console.ReadKey();
        }
    }
}
