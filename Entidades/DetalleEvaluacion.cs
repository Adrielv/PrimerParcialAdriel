using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class DetalleEvaluacion
    {
        [Key]
        public int DetalleEvaluacionId { get; set; }

        public decimal  Logrado { get; set; }

        public string Categoria { get; set; }

        public Decimal Valor { get; set; }

        public decimal Perdido { get; set; }

        
        public virtual Evaluacion Evaluacion { get; set; }


        public int EvaluacionId { get; set; }

        public DetalleEvaluacion()
        {
            DetalleEvaluacionId = 0;
            Logrado = 0;
            Categoria = string.Empty;
            Valor = 0;
            Perdido = 0;         
            EvaluacionId = 0;
        }

        public DetalleEvaluacion(string categoria, decimal valor, decimal logrado, decimal perdido)
        {
            
            Logrado = logrado;
            Categoria = categoria;
            Valor = valor;
            Perdido = perdido;
          
        }
    }
}
