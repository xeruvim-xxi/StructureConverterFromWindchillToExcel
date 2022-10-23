using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureConverterFromWindchillToExcel
{
    [Serializable]
    abstract internal class Component
    {
        private List<Execution> _executions;
        public Designation Design { get { return _executions[CurrentIndexExecution].Design; }  }
        public string Name { get { return _executions[CurrentIndexExecution].Name; } }
        public double Mass { get { return _executions[CurrentIndexExecution].Mass; } }
        public string Material { get { return _executions[CurrentIndexExecution].Material; } }
        public int CurrentIndexExecution { get; private set; }
        public Execution CurrentExecution { get { return _executions[CurrentIndexExecution]; } }

        public Component( Designation design, string name, double mass=0, string material="", Drawing drawing = null)
        {  
            _executions = new List<Execution>();
            _executions.Add(new Execution(this, design, name, mass, material, drawing));
            CurrentIndexExecution = 0;
        }

        public bool SetCurrentExecution(int index)
        {
            if (_executions.Count > index)
            {
                CurrentIndexExecution = index;
                return true;
            }
            return false;
        }

        public override bool Equals(Object obj)
        {
            if (!(obj is Component)) return false;
            Component other = (Component)obj;

            if (this.Design.Equals(other.Design)) return true;
            return false;
        }

        public override int GetHashCode()
        {
            return this.Design.GetHashCode();
        }
    }
    
}
