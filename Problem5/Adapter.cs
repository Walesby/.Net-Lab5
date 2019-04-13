using Problem5.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem5
{
    class Adapter : IPlugAdapter
    {
        Plug plug;
        public Adapter(Plug plug)
        {
            this.plug = plug;
        }

        public void Connect(Outlet outlet)
        {
            plug.Type = outlet.Type;
            this.plug.PlugIn(outlet);
        }

        public void Disconnect()
        {
            this.plug.UnPlug();
        }
    }
}
