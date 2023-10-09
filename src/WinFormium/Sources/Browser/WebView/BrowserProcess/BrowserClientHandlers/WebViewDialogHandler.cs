// THIS FILE IS PART OF WinFormium PROJECT
// THE WinFormium PROJECT IS AN OPENSOURCE LIBRARY LICENSED UNDER THE MIT License.
// COPYRIGHTS (C) Xuanchen Lin. ALL RIGHTS RESERVED.
//
// GITHUB: https://github.com/XuanchenLin/WinFormium
// EMail: xuanchenlin(at)msn.com QQ:19843266 WECHAT:linxuanchen1985

namespace WinFormium.Browser;
internal class WebViewDialogHandler : CefDialogHandler
{
    public IDialogHandler Handler { get; }

    public WebViewDialogHandler(IDialogHandler handler)
    {
        Handler = handler;
    }

    protected override bool OnFileDialog(CefBrowser browser, CefFileDialogMode mode, string title, string defaultFilePath, string[] acceptFilters, CefFileDialogCallback callback)
    {
        return Handler.OnFileDialog(browser, mode, title, defaultFilePath, acceptFilters, callback);
    }
}
