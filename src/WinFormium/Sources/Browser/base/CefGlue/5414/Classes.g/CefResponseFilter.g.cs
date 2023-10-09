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
    public abstract unsafe partial class CefResponseFilter
    {
        private static Dictionary<IntPtr, CefResponseFilter> _roots = new Dictionary<IntPtr, CefResponseFilter>();
        
        private int _refct;
        private cef_response_filter_t* _self;
        
        protected object SyncRoot { get { return this; } }
        
        private cef_response_filter_t.add_ref_delegate _ds0;
        private cef_response_filter_t.release_delegate _ds1;
        private cef_response_filter_t.has_one_ref_delegate _ds2;
        private cef_response_filter_t.has_at_least_one_ref_delegate _ds3;
        private cef_response_filter_t.init_filter_delegate _ds4;
        private cef_response_filter_t.filter_delegate _ds5;
        
        protected CefResponseFilter()
        {
            _self = cef_response_filter_t.Alloc();
        
            _ds0 = new cef_response_filter_t.add_ref_delegate(add_ref);
            _self->_base._add_ref = Marshal.GetFunctionPointerForDelegate(_ds0);
            _ds1 = new cef_response_filter_t.release_delegate(release);
            _self->_base._release = Marshal.GetFunctionPointerForDelegate(_ds1);
            _ds2 = new cef_response_filter_t.has_one_ref_delegate(has_one_ref);
            _self->_base._has_one_ref = Marshal.GetFunctionPointerForDelegate(_ds2);
            _ds3 = new cef_response_filter_t.has_at_least_one_ref_delegate(has_at_least_one_ref);
            _self->_base._has_at_least_one_ref = Marshal.GetFunctionPointerForDelegate(_ds3);
            _ds4 = new cef_response_filter_t.init_filter_delegate(init_filter);
            _self->_init_filter = Marshal.GetFunctionPointerForDelegate(_ds4);
            _ds5 = new cef_response_filter_t.filter_delegate(filter);
            _self->_filter = Marshal.GetFunctionPointerForDelegate(_ds5);
        }
        
        ~CefResponseFilter()
        {
            Dispose(false);
        }
        
        private void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (_self != null)
            {
                cef_response_filter_t.Free(_self);
                _self = null;
            }
        }
        
        private void add_ref(cef_response_filter_t* self)
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
        
        private int release(cef_response_filter_t* self)
        {
            lock (SyncRoot)
            {
                var result = --_refct;
                if (result == 0)
                {
                    lock (_roots) { _roots.Remove((IntPtr)_self); }
                    Dispose();
                    return 1;
                }
                return 0;
            }
        }
        
        private int has_one_ref(cef_response_filter_t* self)
        {
            lock (SyncRoot) { return _refct == 1 ? 1 : 0; }
        }
        
        private int has_at_least_one_ref(cef_response_filter_t* self)
        {
            lock (SyncRoot) { return _refct != 0 ? 1 : 0; }
        }
        
        internal cef_response_filter_t* ToNative()
        {
            add_ref(_self);
            return _self;
        }
        
        [Conditional("DEBUG")]
        private void CheckSelf(cef_response_filter_t* self)
        {
            if (_self != self) throw ExceptionBuilder.InvalidSelfReference();
        }
        
    }
}
