﻿// THIS FILE IS PART OF WinFormium PROJECT
// THE WinFormium PROJECT IS AN OPENSOURCE LIBRARY LICENSED UNDER THE MIT License.
// COPYRIGHTS (C) Xuanchen Lin. ALL RIGHTS RESERVED.
//
// GITHUB: https://github.com/XuanchenLin/WinFormium
// EMail: xuanchenlin(at)msn.com QQ:19843266 WECHAT:linxuanchen1985

namespace WinFormium.CefGlue;

/// <summary>
/// Return value types.
/// </summary>
public enum CefReturnValue
{
    /// <summary>
    /// Cancel immediately.
    /// </summary>
    Cancel = 0,

    /// <summary>
    /// Continue immediately.
    /// </summary>
    Continue,

    /// <summary>
    /// Continue asynchronously (usually via a callback).
    /// </summary>
    ContinueAsync,
}
