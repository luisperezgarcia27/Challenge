using ApiN5.Models.Nf;

namespace ApiN5.Models.PermissionTypeM
{
    public class PermissionTypeM
    {
        public List<TipoPermiso> Read()
        {
            using (N5Context context = new N5Context())
            {
                return context.TipoPermisos.ToList();
            }
        }
    }
}
