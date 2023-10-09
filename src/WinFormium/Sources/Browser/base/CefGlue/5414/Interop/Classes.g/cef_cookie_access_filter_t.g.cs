﻿//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace WinFormium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_cookie_access_filter_t
    {
        internal cef_base_ref_counted_t _base;
        internal IntPtr _can_send_cookie;
        internal IntPtr _can_save_cookie;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void add_ref_delegate(cef_cookie_access_filter_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int release_delegate(cef_cookie_access_filter_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_one_ref_delegate(cef_cookie_access_filter_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_at_least_one_ref_delegate(cef_cookie_access_filter_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int can_send_cookie_delegate(cef_cookie_access_filter_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_cookie_t* cookie);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int can_save_cookie_delegate(cef_cookie_access_filter_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_response_t* response, cef_cookie_t* cookie);
        
        private static int _sizeof;
        
        static cef_cookie_access_filter_t()
        {
            _sizeof = Marshal.SizeOf(typeof(cef_cookie_access_filter_t));
        }
        
        internal static cef_cookie_access_filter_t* Alloc()
        {
            var ptr = (cef_cookie_access_filter_t*)Marshal.AllocHGlobal(_sizeof);
            *ptr = new cef_cookie_access_filter_t();
            ptr->_base._size = (UIntPtr)_sizeof;
            return ptr;
        }
        
        internal static void Free(cef_cookie_access_filter_t* ptr)
        {
            Marshal.FreeHGlobal((IntPtr)ptr);
        }
        
    }
}
