using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureConverterFromWindchillToExcel
{
    

    [Serializable]
    internal class Specification
    {
        public Designation Design { get; set; }
        public string Name { get; set; }
        public Asm BaseAsm { get; private set; }
        public List<ObjectSpecification> ObjectsSpecification { get; private set; }

        public Specification(Designation design, string name, Asm asm)
        {
            Design = new Designation(design.BaseName, design.NumberExecution);
            Name = name;
            BaseAsm = asm;
            ObjectsSpecification = new List<ObjectSpecification>();
        }

        public bool AddObjSpecification (ObjectSpecification objectSpecification)
        {
            if (ObjectsSpecification.Find(x => ((x.Object.Design.BaseName == objectSpecification.Object.Design.BaseName) && (x.Object.Design.NumberExecution == objectSpecification.Object.Design.NumberExecution)) ) == null)
            {
                ObjectsSpecification.Add(objectSpecification);
                return true;
            }
            return false;
        }

        public bool DeleteObjSpecification (ObjectSpecification objectSpecification)
        {
            if (ObjectsSpecification.Find(x => ((x.Object.Design.BaseName == objectSpecification.Object.Design.BaseName) && (x.Object.Design.NumberExecution == objectSpecification.Object.Design.NumberExecution))) != null)
            {
                ObjectsSpecification.Remove(objectSpecification);
                return true;
            }
            return false;
        }

        public ObjectSpecification GetObjectSpecificationByIndex(int index)
        {
            if(index < 0 || index >= ObjectsSpecification.Count) return null;
            return ObjectsSpecification[index];
        }

    }

    internal class ObjectSpecification
    {
        public Execution Object { get; private set; } // ссылка на объект
        public int Pos { get; private set; } // номер позиции
        public Section Section { get; private set; } // раздел
        public int SubSection { get; private set; } // подраздел
        public int Quantity { get; private set; } // количество
        public string Note { get; private set; } // примечание


        public ObjectSpecification(Execution obj, int pos, Section section = Section.DETAILS, int subSection = 0, int quantity = 1, string note = "")
        {
            Object = obj;
            Pos = pos;
            Section = section;
            SubSection = subSection;
            Quantity = quantity;
            Note = note;
        }

        public void SetPos(int pos)
        {
            Pos = pos;
        }

        public void SetSection(Section section)
        {
            Section = section;
        }

        public void SetSubSection(int subsection)
        {
            SubSection = subsection;
        }

        public void SetQuantity(int kol)
        {
            Quantity = kol;
        }

        public void SetNote(string note)
        {
            Note = note;
        }

    }
}