using System;
using System.Collections.Generic;

namespace ApiN5.Models.Nf
{
    public partial class TipoPermiso
    {
        public TipoPermiso()
        {
            Permisos = new HashSet<Permiso>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Permiso> Permisos { get; set; }
    }
}
