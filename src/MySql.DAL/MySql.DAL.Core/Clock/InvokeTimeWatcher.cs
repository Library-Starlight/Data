using System;
using System.Collections.Generic;
using System.Text;

namespace MySql.DAL.Core.Clock
{
    public class InvokeTimeWatcher : IDisposable
    {
        private readonly DateTime _startTime = DateTime.Now;

        public void Dispose()
        {
            var elapsed = DateTime.Now - _startTime;
            Console.WriteLine($"花费时间：{elapsed.TotalSeconds}");
        }
    }
}
