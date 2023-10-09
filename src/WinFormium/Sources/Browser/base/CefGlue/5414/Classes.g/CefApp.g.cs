﻿//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace WinFormium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using WinFormium.CefGlue.Interop;
    
    // Role: HANDLER
    public abstract unsafe partial class CefApp
    {
        private static Dictionary<IntPtr, CefApp> _roots = new Dictionary<IntPtr, CefApp>();
        
        private int _refct;
        private cef_app_t* _self;
        
        protected object SyncRoot { get { return this; } }
        
        private cef_app_t.add_ref_delegate _ds0;
        private cef_app_t.release_delegate _ds1;
        private cef_app_t.has_one_ref_delegate _ds2;
        private cef_app_t.has_at_least_one_ref_delegate _ds3;
        private cef_app_t.on_before_command_line_processing_delegate _ds4;
        private cef_app_t.on_register_custom_schemes_delegate _ds5;
        private cef_app_t.get_resource_bundle_handler_delegate _ds6;
        private cef_app_t.get_browser_process_handler_delegate _ds7;
        private cef_app_t.get_render_process_handler_delegate _ds8;
        
        protected CefApp()
        {
            _self = cef_app_t.Alloc();
        
            _ds0 = new cef_app_t.add_ref_delegate(add_ref);
            _self->_base._add_ref = Marshal.GetFunctionPointerForDelegate(_ds0);
            _ds1 = new cef_app_t.release_delegate(release);
            _self->_base._release = Marshal.GetFunctionPointerForDelegate(_ds1);
            _ds2 = new cef_app_t.has_one_ref_delegate(has_one_ref);
            _self->_base._has_one_ref = Marshal.GetFunctionPointerForDelegate(_ds2);
            _ds3 = new cef_app_t.has_at_least_one_ref_delegate(has_at_least_one_ref);
            _self->_base._has_at_least_one_ref = Marshal.GetFunctionPointerForDelegate(_ds3);
            _ds4 = new cef_app_t.on_before_command_line_processing_delegate(on_before_command_line_processing);
            _self->_on_before_command_line_processing = Marshal.GetFunctionPointerForDelegate(_ds4);
            _ds5 = new cef_app_t.on_register_custom_schemes_delegate(on_register_custom_schemes);
            _self->_on_register_custom_schemes = Marshal.GetFunctionPointerForDelegate(_ds5);
            _ds6 = new cef_app_t.get_resource_bundle_handler_delegate(get_resource_bundle_handler);
            _self->_get_resource_bundle_handler = Marshal.GetFunctionPointerForDelegate(_ds6);
            _ds7 = new cef_app_t.get_browser_process_handler_delegate(get_browser_process_handler);
            _self->_get_browser_process_handler = Marshal.GetFunctionPointerForDelegate(_ds7);
            _ds8 = new cef_app_t.get_render_process_handler_delegate(get_render_process_handler);
            _self->_get_render_process_handler = Marshal.GetFunctionPointerForDelegate(_ds8);
        }
        
        ~CefApp()
        {
            Dispose(false);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (_self != null)
            {
                cef_app_t.Free(_self);
                _self = null;
            }
        }
        
        private void add_ref(cef_app_t* self)
        {
            lock (SyncRoot)
            {
                var result = ++_refct;
                if (result == 1)
                {
                    lock (_roots) { _roots.Add((IntPtr)_self, this); }
                }
            }
        }
        
        private int release(cef_app_t* self)
        {
            lock (SyncRoot)
            {
                var result = --_refct;
                if (result == 0)
                {
                    lock (_roots) { _roots.Remove((IntPtr)_self); }
                    return 1;
                }
                return 0;
            }
        }
        
        private int has_one_ref(cef_app_t* self)
        {
            lock (SyncRoot) { return _refct == 1 ? 1 : 0; }
        }
        
        private int has_at_least_one_ref(cef_app_t* self)
        {
            lock (SyncRoot) { return _refct != 0 ? 1 : 0; }
        }
        
        internal cef_app_t* ToNative()
        {
            add_ref(_self);
            return _self;
        }
        
        [Conditional("DEBUG")]
        private void CheckSelf(cef_app_t* self)
        {
            if (_self != self) throw ExceptionBuilder.InvalidSelfReference();
        }
        
    }
}
