using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.CustomDIOC
{
    [AttributeUsage(AttributeTargets.Constructor)]
    public class RichardInjectionConstructorAttribute : Attribute
    {
        public RichardInjectionConstructorAttribute()
        { 
        
        }
    }
}
