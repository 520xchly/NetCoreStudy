using IBIL;
using System;
using System.Collections.Generic;
using System.Text;

namespace BIL
{
    public class ApiTestBIL : IApiTestBIL
    {
        public ApiTestBIL()
        {
            Console.WriteLine("this is ApiTestBIL 构造函数");
        }

        public void Show()
        {
            Console.WriteLine("this is ApiTestBIL Show");
        }
    }
}
