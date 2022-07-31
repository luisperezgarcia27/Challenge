namespace ApiN5.Models.PermisoM
{
    public class PermissionModel
    {
        public int Id { get; set; }
        public string NombreEmpleado { get; set; } = null!;
        public string ApellidoEmpleado { get; set; } = null!;
        public int TipoPermiso { get; set; }
        public string TipoPermisoNavigation { get; set; }
        public DateTime FechaPermiso { get; set; }

    }
}
