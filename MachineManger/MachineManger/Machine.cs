using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineManger
{
    internal enum MachineType
    {
        Mechanical,
        electronic,
        electrical,
        other
    }
    class Machine
    {
          //pties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Constructor { get; set; }
        public String Type { get; set; }
        public bool State { get; set; }

        public override bool Equals(object obj)
        {
            var machine = obj as Machine;
            return machine != null &&
                   Id == machine.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }



        //Add tow constractors one with parameters an other without
        //redefine methods Equals and HashCode


    }

    
}
