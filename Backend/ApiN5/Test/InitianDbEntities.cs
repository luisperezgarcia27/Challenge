using ApiN5.Models.PermisoM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class InitianDbEntities
    {
        public List<PermissionModel> getInitialDbEntities()
        {
            return new List<PermissionModel>
             {
                new PermissionModel {Id = 1, NombreEmpleado="Luis", ApellidoEmpleado="Perez", TipoPermiso = 1, TipoPermisoNavigation = "Deberes públicos", FechaPermiso = new DateTime(2022, 7, 28)},
                  new PermissionModel {Id = 2, NombreEmpleado="Juan", ApellidoEmpleado="Garcia", TipoPermiso = 1, TipoPermisoNavigation = "Deberes públicos", FechaPermiso = new DateTime(2022, 7, 28)},
                      new PermissionModel {Id = 3, NombreEmpleado="Steven", ApellidoEmpleado="Rodriguez", TipoPermiso = 2, TipoPermisoNavigation = "Mudanza", FechaPermiso = new DateTime(2022, 7, 28)},
            };
        }
    }
}
