﻿// THIS FILE IS PART OF WinFormium PROJECT
// THE WinFormium PROJECT IS AN OPENSOURCE LIBRARY LICENSED UNDER THE MIT License.
// COPYRIGHTS (C) Xuanchen Lin. ALL RIGHTS RESERVED.
//
// GITHUB: https://github.com/XuanchenLin/WinFormium
// EMail: xuanchenlin(at)msn.com QQ:19843266 WECHAT:linxuanchen1985


using WinFormium.CefGlue.Interop;

namespace WinFormium.CefGlue;
/// <summary>
/// Implement this interface for asynchronous task execution. If the task is
/// posted successfully and if the associated message loop is still running then
/// the Execute() method will be called on the target thread. If the task fails
/// to post then the task object may be destroyed on the source thread instead
/// of the target thread. For this reason be cautious when performing work in
/// the task object destructor.
/// </summary>
public abstract unsafe partial class CefTask
{
    private void execute(cef_task_t* self)
    {
        CheckSelf(self);

        Execute();
    }

    /// <summary>
    /// Method that will be executed on the target thread.
    /// </summary>
    protected abstract void Execute();
}