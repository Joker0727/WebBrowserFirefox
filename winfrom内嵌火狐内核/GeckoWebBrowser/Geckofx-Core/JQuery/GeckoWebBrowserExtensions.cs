using System.Collections.Generic;

namespace Gecko.JQuery
{
    public static class GeckoWebBrowserExtensions
    {
        public static JsVal ExecuteJQuery(IGeckoWebBrowser browser, string jQuery)
        {
            var jquery = new JQueryExecutor(browser.Window);

            return jquery.ExecuteJQuery(jQuery);
        }

        public static GeckoElement GetElementByJQuery(IGeckoWebBrowser browser, string jQuery)
        {
            var jquery = new JQueryExecutor(browser.Window);

            return jquery.GetElementByJQuery(jQuery);
        }

        public static IEnumerable<GeckoElement> GetElementsByJQuery(IGeckoWebBrowser browser, string jQuery)
        {
            var jquery = new JQueryExecutor(browser.Window);

            return jquery.GetElementsByJQuery(jQuery);
        }
    }
}
