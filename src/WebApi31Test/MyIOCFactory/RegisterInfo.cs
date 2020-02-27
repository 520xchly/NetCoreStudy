using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.CustomDIOC
{
    public class RegisterInfo
    {
        public Type TargetType { get; set; }
         
        //生命周期

        public LifeTimeType LifeTime { get; set; }
    }

    public enum LifeTimeType
    {
        Transient,
        Singleton,
        PerThread
    }
}
