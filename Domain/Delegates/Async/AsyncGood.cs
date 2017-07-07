using System;
using System.Threading;

namespace Domain.Delegates.Async
{
    public class AsyncGood
    {
        delegate void StartProcessDelegate(int value);
        delegate void ShowProgressDelegate(int value);

        private int pbStatus;

        private void StartButton_Click(object sender, EventArgs e)
        {
            var progDelegate = new StartProcessDelegate(StartProcess);
            progDelegate.BeginInvoke(100, null, null);
            Console.WriteLine("Done With operation");
        }

        // Called Asynchronously
        private void StartProcess(int max)
        {
            for (var i = 0; i <= max; i++)
            {
                Thread.Sleep(10);
                pbStatus = i;
                Console.WriteLine(pbStatus);
            }
        }

        private void ShowProgress(int i)
        {
            // This is hit if a background thread calls ShowProgress()
            // Swapping the thread to change the UI back to the GUI thread
            // Ignore below red line, pretend this is a UWP app
            //if (label.InvokeRequired)
            //{
            //    var del = new ShowProgressDelegate(ShowProgress);
            //    this.BeginInvoke(del, new object[] { i });
            //}
            //else
            //{
            //    label.Text = i.ToString();
            //    pbStatus = i;
            //}
        }
    }
}
