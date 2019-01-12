using System;
using System.Collections.Generic;

using System.Text;
using Gecko.Interop;

namespace Gecko.DOM.Svg
{
    public class SvgElement
        : GeckoElement
    {
        private nsIDOMSVGElement _svgElement;

        protected SvgElement(nsIDOMSVGElement svgElement)
            : base(svgElement)
        {
            _svgElement = svgElement;
        }

        public string ID
        {
            get { return nsString.Get(_svgElement.GetIdAttribute); }
            set { nsString.Set(_svgElement.SetIdAttribute, value); }
        }

        public SvgSvgElement OwnerSvgElement
        {
            get { return Gecko.Interop.ExtensionMethods.Wrap(_svgElement.GetOwnerSVGElementAttribute(), SvgSvgElement.CreateSvgSvgElementWrapper); }
        }

        public SvgElement ViewportElement
        {
            get { return Gecko.Interop.ExtensionMethods.Wrap(_svgElement.GetViewportElementAttribute(), CreateSvgElementWrapper); }
        }

        public static SvgElement CreateSvgElementWrapper(nsIDOMSVGElement svgElement)
        {
            return svgElement == null ? null : new SvgElement(svgElement);
        }
    }
}