using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureConverterFromWindchillToExcel
{
    internal class TempObject
    {
        public int Level { get; set; }
        public Section Section { get; set; }
        public string Design { get; set; }
        public string Name { get; set; }
        public int Pos { get; set; }
        public double Quantity { get; set; }
        public double Mass { get; set; }
        public string Material1 { get; set; }
        public string Material2 { get; set; }
        public string Note { get; set; }
        public string ParentDesign { get; set; }

        public TempObject(int level, Section section, string design, string name, int pos, double quantity, double mass, string material1, string material2, string note, string parentdesign = "")
        {
            Level = level;
            Section = section;
            Design = design;
            Name = name;
            Pos = pos;
            Quantity = quantity;
            Mass = mass;
            Material1 = material1;
            Material2 = material2;
            Note = note;
            ParentDesign = parentdesign;
        }

        public TempObject()
        {
        }
    }
}
