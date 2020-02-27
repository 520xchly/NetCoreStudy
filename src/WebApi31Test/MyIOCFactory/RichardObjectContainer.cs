using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Common.CustomDIOC
{

    #region 自定义IOC

    
    ///// <summary>
    ///// 升级代码：要只是三种生命周期：
    ///// </summary>

    //public interface IRichardObjectContainer
    //{
    //    void RegisterType<TFrom, TTo>(LifeTimeType lifeTime = LifeTimeType.Transient);

    //    T Resolve<T>();

    //}

    //public class RichardObjectContainer : IRichardObjectContainer
    //{ 
    //    private Dictionary<string, RegisterInfo> RichardContainnerDictionary = new Dictionary<string, RegisterInfo>(); 
    //    private Dictionary<Type, object> TypeObjectDictionary = new Dictionary<Type, object>(); 
    //    /// <summary>
    //    /// 注册
    //    /// </summary>
    //    /// <typeparam name="TFrom">抽象</typeparam>
    //    /// <typeparam name="TTo">细节</typeparam>
    //    public void RegisterType<TFrom, TTo>(LifeTimeType lifeTime = LifeTimeType.Transient)
    //    {
    //        RichardContainnerDictionary.Add(typeof(TFrom).FullName, new RegisterInfo()
    //        {
    //            TargetType = typeof(TTo),
    //            LifeTime = lifeTime
    //        });
    //    }

    //    /// <summary>
    //    /// 获取对象实例
    //    /// </summary>
    //    /// <typeparam name="TFrom"></typeparam>
    //    /// <returns></returns>
    //    public TFrom Resolve<TFrom>()
    //    {
    //        #region 支持构造函数

    //        RegisterInfo info = RichardContainnerDictionary[typeof(TFrom).FullName];
    //        Type type = info.TargetType;

    //        TFrom t = default(TFrom);
    //        switch (info.LifeTime)
    //        {
    //            case LifeTimeType.Transient: //瞬时生命周期
    //                t = (TFrom)this.CreateObject(type);
    //                break;
    //            case LifeTimeType.Singleton:
    //                if (this.TypeObjectDictionary.ContainsKey(type))
    //                {
    //                    t = (TFrom)this.TypeObjectDictionary[type];
    //                }
    //                else
    //                {
    //                    t = (TFrom)this.CreateObject(type);
    //                    this.TypeObjectDictionary[type] = t;
    //                }
    //                break;
    //            case LifeTimeType.PerThread:
    //                //同一个线程下是一个实例--线程槽
    //                // CallContext.SetData() //在同一个线程中，可以设置一堆Key Value 键值对进入；
    //                //CallContext.GetData()
    //                string key = type.FullName;
    //                object oValue = CallContext.GetData(key);
    //                if (oValue == null)
    //                {
    //                    t = (TFrom)this.CreateObject(type);
    //                    CallContext.SetData(key, t);
    //                }
    //                else
    //                {
    //                    t = (TFrom)oValue;
    //                }
    //                break;
    //            default:
    //                throw new Exception("当前传入的枚举值不正确");
    //        }
    //        #endregion
    //        return t;
    //    }

    //    private object CreateObject(Type type)
    //    {
    //        ConstructorInfo[] ctorArray = type.GetConstructors(); //找到所有的构造函数 
    //        ConstructorInfo ctor = null;
    //        if (ctorArray.Count(c => c.IsDefined(typeof(RichardInjectionConstructorAttribute), true)) > 0)
    //        {
    //            ctor = ctorArray.FirstOrDefault(c => c.IsDefined(typeof(RichardInjectionConstructorAttribute), true));
    //        }
    //        else
    //        {
    //            ctor = ctorArray.OrderByDescending(c => c.GetParameters().Length).FirstOrDefault();
    //        }
    //        List<object> paraList = new List<object>();
    //        foreach (var parameter in ctor.GetParameters())
    //        {
    //            Type paraType = parameter.ParameterType;
    //            RegisterInfo inof = RichardContainnerDictionary[paraType.FullName];
    //            Type tagetType = inof.TargetType;
    //            object para = null;
    //            switch (inof.LifeTime)
    //            {
    //                case LifeTimeType.Transient:
    //                    para = this.CreateObject(tagetType);
    //                    break;
    //                case LifeTimeType.Singleton:
    //                    if (this.TypeObjectDictionary.ContainsKey(tagetType))
    //                    {
    //                        para = this.TypeObjectDictionary[tagetType];
    //                    }
    //                    else
    //                    {
    //                        para = this.CreateObject(tagetType);
    //                        this.TypeObjectDictionary[tagetType] = para;
    //                    }
    //                    break;
    //                case LifeTimeType.PerThread:
    //                    string key = tagetType.FullName;
    //                    object oValue = CallContext.GetData(key);
    //                    if (oValue == null)
    //                    {
    //                        para = this.CreateObject(tagetType);
    //                        CallContext.SetData(key, para);
    //                    }
    //                    else
    //                    {
    //                        para = oValue;
    //                    }
    //                    break;
    //                default:
    //                    throw new Exception("当前传入的枚举值不正确");
    //            } 
    //            paraList.Add(para);
    //        }
    //        return Activator.CreateInstance(type, paraList.ToArray());
    //    }

    //    //那么方法注入和属性注入呢？

    //}

    #endregion
}
