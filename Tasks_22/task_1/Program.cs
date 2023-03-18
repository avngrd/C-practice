using System;
using task_1;

namespace MyNameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            CarEngine audiEngine = CarEngine.getState();
            audiEngine.engineState();
            audiEngine.oilFill();
            audiEngine.engineState();
            audiEngine.oilCheck();
            audiEngine.engineState();
            audiEngine.startEngine();
            audiEngine.engineState();
        }
    }
}