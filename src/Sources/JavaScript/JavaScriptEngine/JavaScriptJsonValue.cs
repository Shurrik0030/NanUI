// THIS FILE IS PART OF NanUI PROJECT
// THE NanUI PROJECT IS AN OPENSOURCE LIBRARY LICENSED UNDER THE MIT License.
// COPYRIGHTS (C) Xuanchen Lin. ALL RIGHTS RESERVED.
// GITHUB: https://github.com/XuanchenLin/NanUI

namespace NetDimension.NanUI.JavaScript;

public class JavaScriptJsonValue : JavaScriptValue
{
    public JavaScriptJsonValue(string source)
        : base(JavaScriptValueType.Json, source) { }

    public JavaScriptJsonValue(object source)
        : base(JavaScriptValueType.Json, JsonSerializer.Serialize(source)) { }

    public T? GetObject<T>()
    {
        var value = (string?)RawValue;

        if (value == null) return default(T);

        return JsonSerializer.Deserialize<T>(value);
    }

}
