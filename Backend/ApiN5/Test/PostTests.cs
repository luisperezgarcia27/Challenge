using ApiN5.Models.Nf;
using ApiN5.Models.PermisoM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    internal class PostTests
    {
        [TestMethod]
        public void PostPermission()
        {
            //Arrange
            PermissionModel toBeAdded = new PermissionModel() { Id = 4, NombreEmpleado = "Alejandro", ApellidoEmpleado = "Mendoza", TipoPermiso = 1, TipoPermisoNavigation = "Deberes públicos", FechaPermiso = new DateTime(2022, 7, 28) };

            N5Context context = new N5Context();
            //Act
            PermissionM model = new PermissionM();
            model.Create(toBeAdded);

            //Assert
            Assert.Equals(toBeAdded, context.Permisos.Find(toBeAdded.Id));
        }
    }
}
