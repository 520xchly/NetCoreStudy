using BIL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi31Test.Controllers;

namespace WebApi31Test.MyFactory
{
    public class MyControllerFactory : IControllerFactory
    {
        public object CreateController(ControllerContext context)
        {
            
            return Activator.CreateInstance(typeof(ApiTestController)
                //,new object[] {
                //new ApiTestBIL(),new Logger<ApiTestController>(new LoggerFactory())
                //}
            ) as ControllerBase;
        }

        public void ReleaseController(ControllerContext context, object controller)
        {

        }
    }

    public class CloudControllerActivator : IControllerActivator
    {
        public object Create(ControllerContext context)
        {
            return Activator.CreateInstance(typeof(ApiTestController), new object[] {
                new ApiTestBIL(),new Logger<ApiTestController>(new LoggerFactory())
                }
            ) as ControllerBase;
        }

        public void Release(ControllerContext context, object controller)
        {

        }
    }
}
