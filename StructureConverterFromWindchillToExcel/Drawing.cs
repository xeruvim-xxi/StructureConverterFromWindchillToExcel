using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureConverterFromWindchillToExcel
{
    internal class Drawing
    {
        public string Path { get; private set; }
        public string Version { get; private set; }
        public Execution Parent { get; private set; }

        public Drawing (string path, string version, Execution parent)
        {
            Path = path;
            Version = version;
            Parent = parent;
        }
    }
}
