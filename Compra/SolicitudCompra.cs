using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compra
{
    public class SolicitudCompra
    {

        public string nombreProducto { get; set; }
        public string descripcionProducto { get; set; }
        public string hash { get; set; }
        public string precio { get; set; }
        public string vendedor { get; set; }
        public string comprador { get; set; }
    }
}
