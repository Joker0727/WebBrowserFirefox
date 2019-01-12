using System;
using System.Collections.Generic;
using System.Text;

namespace Gecko.Events
{
    public class GeckoDocumentCompletedEventArgs : EventArgs
    {
        public Uri Uri { get; private set; }
        public GeckoWindow Window { get; private set; }

        public bool IsTopLevel
        {

            get { return Gecko.GeckoWindowExtension.IsTopWindow(Window); }
        }

        public GeckoDocumentCompletedEventArgs(Uri uri, GeckoWindow window)
        {
            this.Uri = uri;
            this.Window = window;
        }
    }
}