using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log4net
{
   public class Log : ILog
   {
      public void Debug(string msg)
      {
#if DEBUG
         Console.WriteLine(msg);
#endif
      }

      public void DebugFormat(string msg, params object[] p)
      {
#if DEBUG
         Console.WriteLine(msg, p);
#endif
      }
   }

   public interface ILog
   {
      void Debug(string msg);
      void DebugFormat(string msg, params object[] p);
   }

   public interface ILogInactive : ILog { }

   public class LogManager
   {
      public static ILog GetLogger(Type type)
      {
         return new Log();
      }
   }
}

namespace log4net.Core
{

}
