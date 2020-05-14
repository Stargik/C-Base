using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    struct Train
    {
        public readonly string nameTarget, timeToGo;
        public int numberTrain;
        public Train(string nameTarget, int numberTrain, string timeToGo)
        {
            this.nameTarget = nameTarget;
            this.numberTrain = numberTrain;
            this.timeToGo = timeToGo;
        }
    }
}
