using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureConverterFromWindchillToExcel
{
    [Serializable]
    internal class ItemComposition
    {       
        public int Position { get; set; }  // номер позиции
        public Product Item { get; set; } // единица состава
        public int Quantity { get; set; } // количество
    }
}
