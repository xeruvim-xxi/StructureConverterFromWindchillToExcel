using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureConverterFromWindchillToExcel
{
    [Serializable]
    internal class Product
    {
        public TypeProduct TypeProduct { get; }
        public Designation Design { get; private set; }
        public string Name { get; set; }

        private double _mass = 0.0;
        public double Mass { get { return MassUpdate(); } set { _mass = value; } }
        public string Material { get; set; }
        public string PathFileModel3D { get; set; }
        public string PathDrawing { get; set; }
        public string PathSpecification { get; set; }
        public List<ItemComposition> Composition { get; set; }

        public Product (TypeProduct typeProduct, Designation designation, string name)
        {
            TypeProduct = typeProduct;
            Design = new Designation(designation.BaseName, designation.NumberExecution, designation.CodeDocument);
            Name = name;
            switch (TypeProduct)
            {                
                case TypeProduct.ASM:
                    Composition = new List<ItemComposition>();
                    break;
                default:
                    Composition = null;
                    break;
            }
        }

        private double MassUpdate()
        {
            switch (TypeProduct)
            {
                case TypeProduct.ASM:
                    double mass = 0.0;
                    foreach (var item in Composition)
                    {
                        mass += item.Item.Mass * item.Quantity;
                    }
                    return mass;
                default:
                    return _mass;
            }
            
        }


    }
}
