using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class DoctorTest
    {
        [Fact]
        static void Get_ResultD()
        {
            //arrange
            var id = 1;

            //act
            var controller = new DoctorController();
            var result = controller.Get(id);

            //assert
            Assert.IsType<List<Doctor>>(result);
        }

        [Fact]
        static void GetId_ResultD_Ok()
        {
            //arrange
            var id = 1;

            //act
            var controller = new DoctorController();
            var result = controller.Get(id);

            //assert
            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        static void Put_ResultD_NotFound()
        {
            //arrange
            var id = 11;

            //act
            var controller = new DoctorController();
            var result = controller.Get(id);

            //assert
            Assert.IsType<NotFound>(result);
        }
    }
}
