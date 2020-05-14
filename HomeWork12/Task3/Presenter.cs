using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Threading;

namespace Task3
{
    class Presenter
    {
        Model model = null;
        MainWindow mainWindow = null;
        DispatcherTimer timer = new DispatcherTimer();
        public Presenter(MainWindow mainWindow)
        {
            model = new Model();
            this.mainWindow = mainWindow;
            mainWindow.StartEvent += new EventHandler(mainWindow_Start);
            mainWindow.StopEvent += new EventHandler(mainWindow_Stop);
            mainWindow.ResetEvent += new EventHandler(mainWindow_Reset);
            timer.Tick += new EventHandler(model.Increase);
            timer.Tick += new EventHandler(mainWindow_StartEvent);
            timer.Interval = new TimeSpan(10000000);
        }

        private void mainWindow_Reset(object sender, EventArgs e)
        {
            timer.Stop();
            model.Reset();
            mainWindow.counter.Content = "0";

        }

        private void mainWindow_Stop(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void mainWindow_Start(object sender, EventArgs e)
        {
            timer.Start();
        }
        private void mainWindow_StartEvent(object sender, EventArgs e)
        {
            string res = model.counter.ToString();
            mainWindow.counter.Content = res;
            
        }
    }
}
