using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    // интерфейс процессы жизнедеятельности
    public interface IVitalActivity
    {
        void Eat();
        void Breathe();
        void Reproduction();
    }
}
