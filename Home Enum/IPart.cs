using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Enum
{
    interface IPart
    {
        string Name { get; }

    }

    class Basement_Home : IPart
    {
        public string Name => "фундамент";
    }
    class Walls_Home : IPart
    {
        public string Name => "Стена";
    }
    class Door_Home : IPart
    {
        public string Name => "дверь";
    }
    class Window_Home : IPart
    {
        public string Name => "Окно";
    }
    class Roof_Home : IPart
    {
        public string Name => "Крыша";
    }
    static class Home
    {
        public static IPart Basement { get; } = new Basement_Home();
        public static IPart Walls { get; } = new Walls_Home();
        public static IPart Door { get; } = new Door_Home();
        public static IPart Window { get; } = new Window_Home();
        public static IPart Roof { get; } = new Roof_Home();

       
    }
}
