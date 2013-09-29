using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2_0;


namespace lab2_1
{
    class lab2_1s
    {
        static void Main(string[] args)
        {
            
            Consolelogger Clog = new Consolelogger();
            Severity s = Severity.Error;
            Clog.Log(s, "Error");
            Clog.Indent();
            s = Severity.Warning;
            Clog.Log(s, "Warning");
            Clog.Unindent();
            s = Severity.Info;
            Clog.Log(s, "Info");
            Console.Read();
        }
    }
}
