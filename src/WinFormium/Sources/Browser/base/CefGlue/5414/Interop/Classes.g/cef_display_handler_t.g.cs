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
    internal unsafe struct cef_display_handler_t
    {
        internal cef_base_ref_counted_t _base;
        internal IntPtr _on_address_change;
        internal IntPtr _on_title_change;
        internal IntPtr _on_favicon_urlchange;
        internal IntPtr _on_fullscreen_mode_change;
        internal IntPtr _on_tooltip;
        internal IntPtr _on_status_message;
        internal IntPtr _on_console_message;
        internal IntPtr _on_auto_resize;
        internal IntPtr _on_loading_progress_change;
        internal IntPtr _on_cursor_change;
        internal IntPtr _on_media_access_change;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void add_ref_delegate(cef_display_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int release_delegate(cef_display_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_one_ref_delegate(cef_display_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_at_least_one_ref_delegate(cef_display_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_address_change_delegate(cef_display_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_string_t* url);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_title_change_delegate(cef_display_handler_t* self, cef_browser_t* browser, cef_string_t* title);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_favicon_urlchange_delegate(cef_display_handler_t* self, cef_browser_t* browser, cef_string_list* icon_urls);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_fullscreen_mode_change_delegate(cef_display_handler_t* self, cef_browser_t* browser, int fullscreen);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int on_tooltip_delegate(cef_display_handler_t* self, cef_browser_t* browser, cef_string_t* text);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_status_message_delegate(cef_display_handler_t* self, cef_browser_t* browser, cef_string_t* value);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int on_console_message_delegate(cef_display_handler_t* self, cef_browser_t* browser, CefLogSeverity level, cef_string_t* message, cef_string_t* source, int line);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int on_auto_resize_delegate(cef_display_handler_t* self, cef_browser_t* browser, cef_size_t* new_size);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_loading_progress_change_delegate(cef_display_handler_t* self, cef_browser_t* browser, double progress);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int on_cursor_change_delegate(cef_display_handler_t* self, cef_browser_t* browser, IntPtr cursor, CefCursorType type, cef_cursor_info_t* custom_cursor_info);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_media_access_change_delegate(cef_display_handler_t* self, cef_browser_t* browser, int has_video_access, int has_audio_access);
        
        private static int _sizeof;
        
        static cef_display_handler_t()
        {
            _sizeof = Marshal.SizeOf(typeof(cef_display_handler_t));
        }
        
        internal static cef_display_handler_t* Alloc()
        {
            var ptr = (cef_display_handler_t*)Marshal.AllocHGlobal(_sizeof);
            *ptr = new cef_display_handler_t();
            ptr->_base._size = (UIntPtr)_sizeof;
            return ptr;
        }
        
        internal static void Free(cef_display_handler_t* ptr)
        {
            Marshal.FreeHGlobal((IntPtr)ptr);
        }
        
    }
}
