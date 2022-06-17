using System;
using Xunit;
using SimpleAPI.Controllers;
namespace SimpleAPI.Test
{
    public class UnitTest1
    {

       WeatherForecastController controller = new WeatherForecastController();
       [Fact]
       public void GetReturnName()
       {
           var retunValue = controller.Get(1);
           Assert.Equal("Manoj Project",retunValue.Value);
       }

        [Fact]
        public void Test1()
        {

        }
    }
}
