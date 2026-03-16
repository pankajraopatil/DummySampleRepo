using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleAppForGITDemo
{
    internal interface IRepo<T>
    {
        bool Add(T Obj);
    }
}
