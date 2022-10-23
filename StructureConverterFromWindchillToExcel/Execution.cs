using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureConverterFromWindchillToExcel
{
    [Serializable]
    internal class Execution
    {
        public Designation Design { get; set; }
        public string Name { get; set; }
        public double Mass { get; set; }
        public string Material { get; set; }
        public Drawing Drawing { get; set; }
        public Component Parent { get; }
        public Execution(Component parent, Designation design, string name, double mass = 0, string material = "", Drawing drawing = null)
        {
            Parent = parent;
            Design = design;
            Name = name;
            Mass = mass;
            Material = material;
            Drawing = new Drawing(drawing.Path, drawing.Version, this);
        }

        public override bool Equals(Object obj)
        {
            if (!(obj is Execution)) return false;
            Execution other = (Execution)obj;

            if (this.Design.Equals(other.Design)) return true;
            return false;
        }

        public override int GetHashCode()
        {
            return this.Design.GetHashCode();
        }
    }
}
