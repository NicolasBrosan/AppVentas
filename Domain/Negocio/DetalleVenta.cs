using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Negocio
{
    public class DetalleVenta
    {
        public int IdDetalle { get; set; }

        //Habría que colocar un detalle de los libros
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string MedioDePago { get; set; }
        public int Cuotas { get; set; }
        public string MedioDeEnvio { get; set; }

    }
}
