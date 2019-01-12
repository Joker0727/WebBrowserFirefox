using System;
using System.Collections.Generic;

using System.Text;
using Gecko.Collections;
using Gecko.Interop;

namespace Gecko.DOM
{
    public class GeckoNamedNodeMap
        : IGeckoArray<GeckoNode>, IEnumerable<GeckoNode>
    {
        private ComPtr<nsIDOMMozNamedAttrMap> _map;

        public GeckoNamedNodeMap(nsIDOMMozNamedAttrMap map)
        {
            // map should be not null
            this._map = new ComPtr<nsIDOMMozNamedAttrMap>(map);
        }


        /// <summary>
        /// Gets the number of items in the map.
        /// </summary>
        public int Length
        {
            get { return (int)_map.Instance.GetLengthAttribute(); }
        }

        public GeckoNode this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                    throw new ArgumentOutOfRangeException("index");

                return Gecko.Interop.ExtensionMethods.Wrap(_map.Instance.Item((uint)index), GeckoNode.Create);
            }
        }

        public GeckoNode this[string name]
        {
            get { return Gecko.Interop.ExtensionMethods.Wrap(nsString.Pass(_map.Instance.GetNamedItem, name), GeckoNode.Create); }
        }

        public GeckoNode this[string namespaceUri, string localName]
        {
            get { return Gecko.Interop.ExtensionMethods.Wrap(nsString.Pass(_map.Instance.GetNamedItemNS, namespaceUri, localName), GeckoNode.Create); }
        }

        public GeckoNode RemoveNamedItem(string name)
        {
            return Gecko.Interop.ExtensionMethods.Wrap(nsString.Pass(_map.Instance.RemoveNamedItem, name), GeckoNode.Create);
        }

        #region IEnumerable<GeckoNode> Members

        public IEnumerator<GeckoNode> GetEnumerator()
        {
            int length = Length;
            for (int i = 0; i < length; i++)
            {
                yield return GeckoNode.Create(_map.Instance.Item((uint)i));
            }
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }
}