using Problem5.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem5
{
    /// <summary>
    /// Adapter is used to allow a plug to connect to an outlet even if they are of different types
    /// </summary>
    class Adapter : IPlugAdapter
    {
        /// <summary>
        /// The Plug that is plugged into the adapter
        /// </summary>
        Plug plug;

        /// <summary>
        /// Creates a new adapter to connect to a plug
        /// </summary>
        /// <param name="plug">Plug that is plugged into the adapter</param>
        public Adapter(Plug plug)
        {
            this.plug = plug;
        }

        /// <summary>
        /// Connects the adapter to the outlet
        /// </summary>
        /// <param name="outlet"></param>
        public void Connect(Outlet outlet)
        {
            plug.Type = outlet.Type;
            this.plug.PlugIn(outlet);
        }

        /// <summary>
        /// Disconnects the adapter from the outlet
        /// </summary>
        public void Disconnect()
        {
            this.plug.UnPlug();
        }
    }
}
