using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Presenter
    {
        Model model = null;
        MainWindow mainWindow = null;

        public Presenter(MainWindow mainWindow)
        {
            this.model = new Model();
            this.mainWindow = mainWindow;
            this.mainWindow.PlusEvent += new EventHandler(mainWindow_PlusEvent);
            this.mainWindow.MinusEvent += new EventHandler(mainWindow_MinusEvent);
            this.mainWindow.MultEvent += new EventHandler(mainWindow_MultEvent);
            this.mainWindow.DivEvent += new EventHandler(mainWindow_DivEvent);
        }

        private void mainWindow_DivEvent(object sender, EventArgs e)
        {
            string result = model.Div(Convert.ToInt32(this.mainWindow.operand1.Text), Convert.ToInt32(this.mainWindow.operand2.Text)).ToString();
            this.mainWindow.result.Content = result;
        }

        private void mainWindow_MultEvent(object sender, EventArgs e)
        {
            string result = model.Mult(Convert.ToInt32(this.mainWindow.operand1.Text), Convert.ToInt32(this.mainWindow.operand2.Text)).ToString();
            this.mainWindow.result.Content = result;
        }

        private void mainWindow_MinusEvent(object sender, EventArgs e)
        {
            string result = model.Minus(Convert.ToInt32(this.mainWindow.operand1.Text), Convert.ToInt32(this.mainWindow.operand2.Text)).ToString();
            this.mainWindow.result.Content = result;
        }

        private void mainWindow_PlusEvent(object sender, EventArgs e)
        {
            string result = model.Plus(Int32.Parse(this.mainWindow.operand1.Text), Int32.Parse(this.mainWindow.operand2.Text)).ToString();
            this.mainWindow.result.Content = result;
        }
    }
}
