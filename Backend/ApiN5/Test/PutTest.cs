using ApiN5.Models.Nf;
using ApiN5.Models.PermisoM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class PutTest
    {
        public void PutPermission()
        {
            //Arrange

            int id = 3;
            PermissionModel updatedItem = new InitianDbEntities().getInitialDbEntities()[2];
            updatedItem.NombreEmpleado = "Esteban";

            //Act

            PermissionM model = new PermissionM();
            model.Update(id, updatedItem);
            Permiso permissionModel = model.ReadId(id);
            //Assert
            Assert.Equals(permissionModel, updatedItem);
        }
    }
}
