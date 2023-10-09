﻿// THIS FILE IS PART OF WinFormium PROJECT
// THE WinFormium PROJECT IS AN OPENSOURCE LIBRARY LICENSED UNDER THE MIT License.
// COPYRIGHTS (C) Xuanchen Lin. ALL RIGHTS RESERVED.
//
// GITHUB: https://github.com/XuanchenLin/WinFormium
// EMail: xuanchenlin(at)msn.com QQ:19843266 WECHAT:linxuanchen1985

namespace WinFormium.JavaScript;

public static class JavaScriptObjectExtension
{
    public static JavaScriptObject ToObject(this JavaScriptValue jsValue)
    {
        if (jsValue != null && jsValue.ValueType == JavaScriptValueType.Object)
        {
            return (JavaScriptObject)jsValue;
        }

        throw new InvalidOperationException($"This is not a {nameof(JavaScriptObject)}.");
    }
}
