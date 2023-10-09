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
    internal unsafe struct cef_cookie_manager_t
    {
        internal cef_base_ref_counted_t _base;
        internal IntPtr _visit_all_cookies;
        internal IntPtr _visit_url_cookies;
        internal IntPtr _set_cookie;
        internal IntPtr _delete_cookies;
        internal IntPtr _flush_store;
        
        // GetGlobalManager
        [DllImport(libcef.DllName, EntryPoint = "cef_cookie_manager_get_global_manager", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_cookie_manager_t* get_global_manager(cef_completion_callback_t* callback);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void add_ref_delegate(cef_cookie_manager_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int release_delegate(cef_cookie_manager_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_one_ref_delegate(cef_cookie_manager_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_at_least_one_ref_delegate(cef_cookie_manager_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int visit_all_cookies_delegate(cef_cookie_manager_t* self, cef_cookie_visitor_t* visitor);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int visit_url_cookies_delegate(cef_cookie_manager_t* self, cef_string_t* url, int includeHttpOnly, cef_cookie_visitor_t* visitor);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int set_cookie_delegate(cef_cookie_manager_t* self, cef_string_t* url, cef_cookie_t* cookie, cef_set_cookie_callback_t* callback);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int delete_cookies_delegate(cef_cookie_manager_t* self, cef_string_t* url, cef_string_t* cookie_name, cef_delete_cookies_callback_t* callback);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int flush_store_delegate(cef_cookie_manager_t* self, cef_completion_callback_t* callback);
        
        // AddRef
        private static IntPtr _p0;
        private static add_ref_delegate _d0;
        
        public static void add_ref(cef_cookie_manager_t* self)
        {
            add_ref_delegate d;
            var p = self->_base._add_ref;
            if (p == _p0) { d = _d0; }
            else
            {
                d = (add_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(add_ref_delegate));
                if (_p0 == IntPtr.Zero) { _d0 = d; _p0 = p; }
            }
            d(self);
        }
        
        // Release
        private static IntPtr _p1;
        private static release_delegate _d1;
        
        public static int release(cef_cookie_manager_t* self)
        {
            release_delegate d;
            var p = self->_base._release;
            if (p == _p1) { d = _d1; }
            else
            {
                d = (release_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(release_delegate));
                if (_p1 == IntPtr.Zero) { _d1 = d; _p1 = p; }
            }
            return d(self);
        }
        
        // HasOneRef
        private static IntPtr _p2;
        private static has_one_ref_delegate _d2;
        
        public static int has_one_ref(cef_cookie_manager_t* self)
        {
            has_one_ref_delegate d;
            var p = self->_base._has_one_ref;
            if (p == _p2) { d = _d2; }
            else
            {
                d = (has_one_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_one_ref_delegate));
                if (_p2 == IntPtr.Zero) { _d2 = d; _p2 = p; }
            }
            return d(self);
        }
        
        // HasAtLeastOneRef
        private static IntPtr _p3;
        private static has_at_least_one_ref_delegate _d3;
        
        public static int has_at_least_one_ref(cef_cookie_manager_t* self)
        {
            has_at_least_one_ref_delegate d;
            var p = self->_base._has_at_least_one_ref;
            if (p == _p3) { d = _d3; }
            else
            {
                d = (has_at_least_one_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_at_least_one_ref_delegate));
                if (_p3 == IntPtr.Zero) { _d3 = d; _p3 = p; }
            }
            return d(self);
        }
        
        // VisitAllCookies
        private static IntPtr _p4;
        private static visit_all_cookies_delegate _d4;
        
        public static int visit_all_cookies(cef_cookie_manager_t* self, cef_cookie_visitor_t* visitor)
        {
            visit_all_cookies_delegate d;
            var p = self->_visit_all_cookies;
            if (p == _p4) { d = _d4; }
            else
            {
                d = (visit_all_cookies_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(visit_all_cookies_delegate));
                if (_p4 == IntPtr.Zero) { _d4 = d; _p4 = p; }
            }
            return d(self, visitor);
        }
        
        // VisitUrlCookies
        private static IntPtr _p5;
        private static visit_url_cookies_delegate _d5;
        
        public static int visit_url_cookies(cef_cookie_manager_t* self, cef_string_t* url, int includeHttpOnly, cef_cookie_visitor_t* visitor)
        {
            visit_url_cookies_delegate d;
            var p = self->_visit_url_cookies;
            if (p == _p5) { d = _d5; }
            else
            {
                d = (visit_url_cookies_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(visit_url_cookies_delegate));
                if (_p5 == IntPtr.Zero) { _d5 = d; _p5 = p; }
            }
            return d(self, url, includeHttpOnly, visitor);
        }
        
        // SetCookie
        private static IntPtr _p6;
        private static set_cookie_delegate _d6;
        
        public static int set_cookie(cef_cookie_manager_t* self, cef_string_t* url, cef_cookie_t* cookie, cef_set_cookie_callback_t* callback)
        {
            set_cookie_delegate d;
            var p = self->_set_cookie;
            if (p == _p6) { d = _d6; }
            else
            {
                d = (set_cookie_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_cookie_delegate));
                if (_p6 == IntPtr.Zero) { _d6 = d; _p6 = p; }
            }
            return d(self, url, cookie, callback);
        }
        
        // DeleteCookies
        private static IntPtr _p7;
        private static delete_cookies_delegate _d7;
        
        public static int delete_cookies(cef_cookie_manager_t* self, cef_string_t* url, cef_string_t* cookie_name, cef_delete_cookies_callback_t* callback)
        {
            delete_cookies_delegate d;
            var p = self->_delete_cookies;
            if (p == _p7) { d = _d7; }
            else
            {
                d = (delete_cookies_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(delete_cookies_delegate));
                if (_p7 == IntPtr.Zero) { _d7 = d; _p7 = p; }
            }
            return d(self, url, cookie_name, callback);
        }
        
        // FlushStore
        private static IntPtr _p8;
        private static flush_store_delegate _d8;
        
        public static int flush_store(cef_cookie_manager_t* self, cef_completion_callback_t* callback)
        {
            flush_store_delegate d;
            var p = self->_flush_store;
            if (p == _p8) { d = _d8; }
            else
            {
                d = (flush_store_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(flush_store_delegate));
                if (_p8 == IntPtr.Zero) { _d8 = d; _p8 = p; }
            }
            return d(self, callback);
        }
        
    }
}
