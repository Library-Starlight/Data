using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.DAL
{
    public class RunningWatcher : IDisposable
    {
        private Stopwatch _sw;

        public RunningWatcher()
        {
            _sw = Stopwatch.StartNew();
        }

        public void Dispose()
        {
            _sw.Stop();
            Console.WriteLine($"运行时间：{_sw.Elapsed.TotalSeconds}秒");
            _sw = null;
        }
    }
}
