using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Delegates.Async
{
    public class AsyncBad
    {
        //delegate void UpdateProgressDelegate(int value);
        Action<int> UpdateProgressDelegate;
        private int pbStatus;

        private void StartButton_Click(object sender, EventArgs e)
        {
            UpdateProgressDelegate += StartProcess;
            UpdateProgressDelegate.BeginInvoke(100, null, null);
            Console.WriteLine("Done With operation");
        }

        // Called Asynchronously
        // This is BAD because helper thread is updating UI components directly
        private void StartProcess(int max)
        {
            for (var i = 0; i <= max; i++)
            {
                Thread.Sleep(10);
                pbStatus = i;
                Console.WriteLine(pbStatus);
            }
        }


    }
}
