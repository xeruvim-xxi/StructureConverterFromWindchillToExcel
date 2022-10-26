using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureConverterFromWindchillToExcel
{
    #region Общие перечисления
    public enum TypeProduct { DETAIL , ASM, STANDARD_PRODUCT, OTHER_PRODUCT, MATERIAL } // тип продукта
    public enum Section { ASSEMBLY_UNITS, DETAILS, STANDARD_PRODUCTS, OTHER_PRODUCTS, MATERIALS, NULL } // разделы спецификации

    public enum CodeDocument { SB } // коды документов

    #endregion
    internal static class Common
    {
        
        public static Section StrToSection(string text)
        {
            text = text.Trim(' ');
            if (text == "СБОРОЧНЫЕ ЕДИНИЦЫ") return Section.ASSEMBLY_UNITS;
            if (text == "ДЕТАЛИ") return Section.DETAILS;
            if (text == "СТАНДАРТНЫЕ ИЗДЕЛИЯ") return Section.STANDARD_PRODUCTS;
            if (text == "ПРОЧИЕ ИЗДЕЛИЯ") return Section.OTHER_PRODUCTS;
            if (text == "МАТЕРИАЛЫ") return Section.MATERIALS;
            return Section.NULL;
        }

        public static string SectionToStr (Section section)
        {
            switch (section)
            {
                case Section.ASSEMBLY_UNITS: return "СБОРОЧНЫЕ ЕДИНИЦЫ";
                case Section.DETAILS: return "ДЕТАЛИ";
                case Section.STANDARD_PRODUCTS: return "СТАНДАРТНЫЕ ИЗДЕЛИЯ";
                case Section.OTHER_PRODUCTS: return "ПРОЧИЕ ИЗДЕЛИЯ";
                case Section.MATERIALS: return "МАТЕРИАЛЫ";
            }
            return "НЕОПРЕДЕЛЕННО";
        }
    }
}
