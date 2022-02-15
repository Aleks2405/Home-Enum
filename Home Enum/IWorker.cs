using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Enum
{
    interface IWorker
    {
        string Work (IPart part)
        {
            return part.Name;
        }
      
        
    }
    class WorkerWWW : IWorker
    {
        public string Work(IPart part)
        {
            return part.Name + "начинаем откуда продолжили";
        }
    }
    class TeamleaderWWW : IWorker
    {
        public string Work(IPart part)
        {
            return part.Name + "Составляю отчет"; 
        }
    }
  
}
