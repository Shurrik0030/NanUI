// THIS FILE IS PART OF NanUI PROJECT
// THE NanUI PROJECT IS AN OPENSOURCE LIBRARY LICENSED UNDER THE MIT License.
// COPYRIGHTS (C) Xuanchen Lin. ALL RIGHTS RESERVED.
// GITHUB: https://github.com/XuanchenLin/NanUI

namespace NetDimension.NanUI.CefGlue.Interop;
[StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
internal unsafe struct cef_string_list
{
    private static readonly string[] Empty = new string[0];

    public static string[] ToArray(cef_string_list* list)
    {
        if (list == null) return null;

        var count = libcef.string_list_size(list);
        if (count == 0) return Empty;

        var result = new string[count];

        cef_string_t n_value = new cef_string_t();
        for (var i = 0; i < count; i++)
        {
            libcef.string_list_value(list, i, &n_value); // FIXME: do not ignore return value of libcef.string_list_value
            result[i] = cef_string_t.ToString(&n_value);
        }

        libcef.string_clear(&n_value);
        return result;
    }

    public static List<string> ToList(cef_string_list* list)
    {
        if (list == null) return null;

        var count = libcef.string_list_size(list);
        if (count == 0) return new List<string>();

        var result = new List<string>(count);

        cef_string_t n_value = new cef_string_t();
        for (var i = 0; i < count; i++)
        {
            libcef.string_list_value(list, i, &n_value); // FIXME: do not ignore return value of libcef.string_list_value
            result.Add(cef_string_t.ToString(&n_value));
        }

        libcef.string_clear(&n_value);
        return result;
    }

    public static cef_string_list* From(string[] list)
    {
        var result = libcef.string_list_alloc();

        if (list != null && list.Length > 0)
        {
            for (var i = 0; i < list.Length; i++)
            {
                var item = list[i];
                fixed (char* item_str = item)
                {
                    var n_item = new cef_string_t(item_str, item != null ? item.Length : 0);
                    libcef.string_list_append(result, &n_item);
                }
            }
        }

        return result;
    }

    public static void AppendTo(cef_string_list* target, IEnumerable<string> values)
    {
        if (values != null)
        {
            foreach (var item in values)
            {
                fixed (char* item_str = item)
                {
                    var n_item = new cef_string_t(item_str, item != null ? item.Length : 0);
                    libcef.string_list_append(target, &n_item);
                }
            }
        }
    }
}
