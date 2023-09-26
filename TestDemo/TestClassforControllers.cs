using Microsoft.AspNetCore.Mvc;
using UnitTest_xUnit_MVC_Core6.Controllers;

namespace TestDemo
{
    public class TestClassforControllers
    {
        [Fact]
        public void Test()
        {
            var HomeCont = new HomeController();
            var Result = HomeCont.Index();
            Assert.IsNotType<OkResult>(Result);
        }
    }
}
