// THIS FILE IS PART OF WinFormium PROJECT
// THE WinFormium PROJECT IS AN OPENSOURCE LIBRARY LICENSED UNDER THE MIT License.
// COPYRIGHTS (C) Xuanchen Lin. ALL RIGHTS RESERVED.
//
// GITHUB: https://github.com/XuanchenLin/WinFormium
// EMail: xuanchenlin(at)msn.com QQ:19843266 WECHAT:linxuanchen1985

namespace WinFormium.Browser;
public sealed class MessageBridgeResponse
{

    //public MessageBridgeResponse(bool isSuccess, string? data = null, string? exception = null)
    //{
    //    IsSuccess = isSuccess;
    //    Data = data;
    //    Exception = exception;
    //}

    public bool IsSuccess { get; set; } = true;

    public string? Exception { get; set; }

    public string? Data { get; set; }




    public string ToJson()
    {
        return JsonSerializer.Serialize(this);
    }

    public static MessageBridgeResponse FromJson(string json)
    {
        return JsonSerializer.Deserialize<MessageBridgeResponse>(json)!;
    }
}
