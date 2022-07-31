using ApiN5.Models.PermisoM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    internal class GetTests
    {
        
        [TestMethod]
        public void GetPermissionAndReturnList()
        {
            //Arrange
            List<PermissionModel> initianDbEntities = new InitianDbEntities().getInitialDbEntities();

            //Act
            PermissionM model = new PermissionM();
            List<PermissionModel> Data = model.Read();

            //Assert
            Assert.Equals(initianDbEntities.Count, Data.Count);
        }
    }
}
