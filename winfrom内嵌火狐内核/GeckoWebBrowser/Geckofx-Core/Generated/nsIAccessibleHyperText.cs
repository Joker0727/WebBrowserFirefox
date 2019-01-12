// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIAccessibleHyperText.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	
	
	/// <summary>
    /// A cross-platform interface that deals with text which contains hyperlinks.
    /// Each link is an embedded object representing exactly 1 character within
    /// the hypertext.
    ///
    /// Current implementation assumes every embedded object is a link.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b33684e2-090c-4e1d-a3d9-f4b46f4237b9")]
	public interface nsIAccessibleHyperText
	{
		
		/// <summary>
        /// Return the number of links contained within this hypertext object.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLinkCountAttribute();
		
		/// <summary>
        /// Return link accessible at the given index.
        ///
        /// @param index  [in] 0-based index of the link that is to be retrieved
        ///
        /// @return       link accessible or null if there is no link at that index
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessibleHyperLink GetLinkAt(int index);
		
		/// <summary>
        /// Return index of the given link.
        ///
        /// @param link  [in] link accessible the index is requested for
        ///
        /// @return      index of the given link or null if there's no link within
        /// hypertext accessible
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLinkIndex([MarshalAs(UnmanagedType.Interface)] nsIAccessibleHyperLink link);
		
		/// <summary>
        /// Return link index at the given offset within hypertext accessible.
        ///
        /// @param offset  [in] the 0-based character index
        ///
        /// @return        0-based link's index or -1 if no link is present at that
        /// offset
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLinkIndexAtOffset(int offset);
	}
}
