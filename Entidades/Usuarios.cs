using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Usuarios
    {
       
        [Key]
        public int UsuariosId { get; set; }

        public Usuarios(int usuariosId)
        {
            this.UsuariosId = usuariosId;
        }
    }
}
