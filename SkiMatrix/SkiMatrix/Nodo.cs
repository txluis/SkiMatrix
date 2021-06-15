using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiMatrix
{
    public class Nodo
    {
        public int value { get; set; }
        public int row { get; set; }
        public int col { get; set; }
        public int rowFather { get; set; }
        public int colFather { get; set; }
    }
}
