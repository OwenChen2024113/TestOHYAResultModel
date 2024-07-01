using System.ComponentModel;

namespace TestOHYAResultModel;

public enum ReturnEnum
{
    /// <summary>回應成功</summary>
    [Description("成功")] Ok = 200,

    /// <summary>登入失敗</summary>
    [Description("登入失敗")] LoginFail = 402,

    /// <summary>取得資料失敗</summary>
    [Description("參數錯誤，取得資料失敗")] GetFail = 422,

    /// <summary>查無資料</summary>
    [Description("查無資料")] NotFound = 404,

    /// <summary>執行失敗</summary>
    [Description("執行失敗")] ExecutionFail = 417,

    /// <summary>後端Error</summary>
    [Description("後端Error")] ServerError = 500
}