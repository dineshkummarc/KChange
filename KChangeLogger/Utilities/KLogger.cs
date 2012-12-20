using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KChangeLogger.Utilities
{
    static class KLogger
    {
        // File I/O - 1
        // Database Operations - 2
        // Debug - 3
        // Critical - 4

        public static bool Log(string Message, int LogType)
        {
            KChangeDataContextDataContext Context = new KChangeDataContextDataContext();

            Log newLog = new Log();
            newLog.Log_Time = DateTime.Now;
            newLog.Log_Message = Message;
            newLog.Log_Type = LogType;

            return Context.AddLog(newLog);
        }
    }
}
