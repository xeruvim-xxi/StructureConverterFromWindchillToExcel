using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureConverterFromWindchillToExcel
{
    internal class Product
    {
        public string Directory { get; private set; }
        public Asm MainAsm { get; private set; }

        public Product (string directory, Designation designation, string name)
        {
            Directory = directory;
            MainAsm = new Asm(new Designation(designation.BaseName, "" , "СБ"), name);
        }
    }
}
