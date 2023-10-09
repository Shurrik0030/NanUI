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
    
    // Role: PROXY
    public sealed unsafe partial class CefXmlReader : IDisposable
    {
        internal static CefXmlReader FromNative(cef_xml_reader_t* ptr)
        {
            return new CefXmlReader(ptr);
        }
        
        internal static CefXmlReader FromNativeOrNull(cef_xml_reader_t* ptr)
        {
            if (ptr == null) return null;
            return new CefXmlReader(ptr);
        }
        
        private cef_xml_reader_t* _self;
        
        private CefXmlReader(cef_xml_reader_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefXmlReader()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
        }
        
        public void Dispose()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
            GC.SuppressFinalize(this);
        }
        
        internal void AddRef()
        {
            cef_xml_reader_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_xml_reader_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_xml_reader_t.has_one_ref(_self) != 0; }
        }
        
        internal bool HasAtLeastOneRef
        {
            get { return cef_xml_reader_t.has_at_least_one_ref(_self) != 0; }
        }
        
        internal cef_xml_reader_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
