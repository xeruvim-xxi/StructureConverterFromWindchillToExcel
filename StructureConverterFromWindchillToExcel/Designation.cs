using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureConverterFromWindchillToExcel
{
       internal class Designation
    {
        public string BaseName { get; set; }
        public string NumberExecution { get; set; }
        public string CodeDocument { get; set; }

        public Designation(string baseName, string numberExecution = "", string codeDocument = "")
        {
            BaseName = baseName;
            NumberExecution = numberExecution;
            CodeDocument = codeDocument;
        }

        public override bool Equals(Object obj)
        {
            if (!(obj is Designation)) return false;

            Designation other = (Designation)obj;

            return BaseName==other.BaseName && NumberExecution==other.NumberExecution && CodeDocument==other.CodeDocument;
        }

        public override int GetHashCode()
        {
            return BaseName.GetHashCode()+NumberExecution.GetHashCode()+CodeDocument.GetHashCode();
        }
    }
}
