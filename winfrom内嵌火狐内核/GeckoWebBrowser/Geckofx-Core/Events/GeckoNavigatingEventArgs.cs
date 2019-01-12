using System;
using System.Collections.Generic;

using System.Text;
using System.ComponentModel;

namespace Gecko.Events
{

    #region GeckoNavigatingEventArgs

    /// <summary>Provides data for event.</summary>
    public class GeckoNavigatingEventArgs
        : CancelEventArgs
    {
        public readonly Uri Uri;
        public readonly GeckoWindow DomWindow;

        public bool DomWindowTopLevel
        {
            get { return Gecko.GeckoWindowExtension.IsTopWindow(DomWindow); }
        }


        /// <summary>Creates a new instance of a <see cref="GeckoNavigatingEventArgs"/> object.</summary>
        /// <param name="value"></param>
        public GeckoNavigatingEventArgs(Uri value, GeckoWindow domWind)
        {
            Uri = value;
            DomWindow = domWind;
        }
    }

    #endregion
}