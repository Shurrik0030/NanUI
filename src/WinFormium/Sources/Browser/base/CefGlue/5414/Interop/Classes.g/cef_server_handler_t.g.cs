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
    internal unsafe struct cef_server_handler_t
    {
        internal cef_base_ref_counted_t _base;
        internal IntPtr _on_server_created;
        internal IntPtr _on_server_destroyed;
        internal IntPtr _on_client_connected;
        internal IntPtr _on_client_disconnected;
        internal IntPtr _on_http_request;
        internal IntPtr _on_web_socket_request;
        internal IntPtr _on_web_socket_connected;
        internal IntPtr _on_web_socket_message;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void add_ref_delegate(cef_server_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int release_delegate(cef_server_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_one_ref_delegate(cef_server_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_at_least_one_ref_delegate(cef_server_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_server_created_delegate(cef_server_handler_t* self, cef_server_t* server);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_server_destroyed_delegate(cef_server_handler_t* self, cef_server_t* server);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_client_connected_delegate(cef_server_handler_t* self, cef_server_t* server, int connection_id);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_client_disconnected_delegate(cef_server_handler_t* self, cef_server_t* server, int connection_id);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_http_request_delegate(cef_server_handler_t* self, cef_server_t* server, int connection_id, cef_string_t* client_address, cef_request_t* request);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_web_socket_request_delegate(cef_server_handler_t* self, cef_server_t* server, int connection_id, cef_string_t* client_address, cef_request_t* request, cef_callback_t* callback);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_web_socket_connected_delegate(cef_server_handler_t* self, cef_server_t* server, int connection_id);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_web_socket_message_delegate(cef_server_handler_t* self, cef_server_t* server, int connection_id, void* data, UIntPtr data_size);
        
        private static int _sizeof;
        
        static cef_server_handler_t()
        {
            _sizeof = Marshal.SizeOf(typeof(cef_server_handler_t));
        }
        
        internal static cef_server_handler_t* Alloc()
        {
            var ptr = (cef_server_handler_t*)Marshal.AllocHGlobal(_sizeof);
            *ptr = new cef_server_handler_t();
            ptr->_base._size = (UIntPtr)_sizeof;
            return ptr;
        }
        
        internal static void Free(cef_server_handler_t* ptr)
        {
            Marshal.FreeHGlobal((IntPtr)ptr);
        }
        
    }
}
