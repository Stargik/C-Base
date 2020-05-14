using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Threading;

namespace Task3
{
    class Model
    {

        public int counter = 0;


        public void Increase(object sender, EventArgs e)
        {
            counter++;
        }

       
        public void Reset()
        {
            counter = 0;
            
        }
    }
}
