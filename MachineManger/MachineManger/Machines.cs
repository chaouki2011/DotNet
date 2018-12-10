using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineManger
{
    class Machines
    {
                
        public List<Machine> ListOfMachines = new List<Machine>();
        
        public List<int> ListOfIds()
        {
            List<int> lstids = new List<int>();

            foreach (Machine x in ListOfMachines)
            {
                lstids.Add(x.Id);
            }
            
            return lstids;
        }
        public Machine FindMachine(int Id)
        {
            Machine m1 = new Machine();
            m1.Id = Id;
            int index = ListOfMachines.IndexOf(m1);
           
            return ListOfMachines[index];
        }

        public bool AddMachine(Machine m)
        {
            if (ListOfMachines.Contains(m))
            {
                return false;
            }
            ListOfMachines.Add(m);
            return true;
        }
        public bool DeleteMachine(int Id)
        {
            Machine m = new Machine();
            m.Id = Id;
            if (!ListOfMachines.Contains(m))
            {
                return false;
            }
            ListOfMachines.Remove(m);
            return true;
        }
    }
}
