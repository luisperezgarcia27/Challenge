using ApiN5.Models.Nf;

namespace ApiN5.Models.PermisoM
{
    public class PermissionM
    {
        public List<PermissionModel> Read()
        {
            using (N5Context context = new N5Context())
            {
                List<PermissionModel> Data = (from a in context.Permisos
                                                 select new PermissionModel
                                                 {
                                                     Id = a.Id,
                                                     NombreEmpleado = a.NombreEmpleado,
                                                     ApellidoEmpleado = a.ApellidoEmpleado,
                                                     FechaPermiso = a.FechaPermiso,
                                                     TipoPermiso = a.TipoPermiso,
                                                     TipoPermisoNavigation = a.TipoPermisoNavigation.Descripcion
                                                 }).ToList();
                return Data;
            }
        }
        public Permiso ReadId(int id)
        {
            using (N5Context context = new N5Context())
            {
                Permiso permiso = context.Permisos.Find(id);
                if (permiso != null)
                {
                    return permiso;
                }
                else
                {
                    return new Permiso();
                }
            }
        }
        public void Create(PermissionModel Data)
        {

            using (N5Context context = new N5Context())
            {
                Permiso permisos = new Permiso();
                permisos.NombreEmpleado = Data.NombreEmpleado;
                permisos.ApellidoEmpleado = Data.ApellidoEmpleado;
                permisos.ApellidoEmpleado = Data.ApellidoEmpleado;
                permisos.FechaPermiso = Data.FechaPermiso;
                permisos.TipoPermiso = Data.TipoPermiso;

                context.Permisos.Add(permisos);
                context.SaveChanges();
            }
        }
        public void Update(int id, PermissionModel Data)
        {
            using (N5Context context = new N5Context())
            {
                Permiso permiso = context.Permisos.Find(id);
                permiso.NombreEmpleado = Data.NombreEmpleado;
                permiso.ApellidoEmpleado = Data.ApellidoEmpleado;
                permiso.TipoPermiso = Data.TipoPermiso;
                permiso.FechaPermiso = Data.FechaPermiso;
                context.SaveChanges();

            }
        }
    }
}
