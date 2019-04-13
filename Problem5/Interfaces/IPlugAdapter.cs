using System;
using System.Collections.Generic;
using System.Text;

namespace Problem5.Interfaces
{
    interface IPlugAdapter
    {
        void Connect(Outlet outlet);
        void Disconnect();
    }
}
