using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Evaluacion
    {
        [Key]
        public int EvalucionId { get; set; }

        public DateTime Fecha { get; set; }

        public string Estudiante { get; set; }


        public decimal Total { get; set; }


        public virtual List<DetalleEvaluacion> Detalle { get; set; }


        public Evaluacion(int evalucionId, DateTime fecha, string estudiante, List<DetalleEvaluacion> detalle,decimal total)
        {
            EvalucionId = evalucionId;
            Fecha = fecha;
            Estudiante = estudiante;
            Detalle = detalle;
            Total = total;
            Detalle = new List<DetalleEvaluacion>();

        }

        public Evaluacion()
        {
            EvalucionId = 0;
            Fecha = DateTime.Now;
            Estudiante = string.Empty;
            Total = 0;
            Detalle = null;

        }
    }
}
