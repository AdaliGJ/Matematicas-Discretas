using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compra
{
    public class InicioTransaccionClass
    {
        public string InformacionCert { get; set; }
        public string ExpiraCert { get; set; }
        public string EntidadCert { get; set; }
        public string FirmaCert { get; set; }
        public string LlaveVendCert { get; set; }
        public string ReguladorCert { get; set; }
        public string identificadorTransaccion { get; set; }
        public string precio { get; set; }
        public string hashProducto { get; set; }
        public string comprador { get; set; }
        public string firmaVendedor { get; set; }
        public string firmaComprador { get; set; }
        public string firmaRegulador { get; set; }
    }
}
