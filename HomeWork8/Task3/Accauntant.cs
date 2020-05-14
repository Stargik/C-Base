using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Accauntant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            if ((int)worker < hours)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
