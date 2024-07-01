namespace TestOHYAResultModel;

public class ResultModelDto
{
    /// <summary>預設成功與空訊息</summary>
    public ResultModelDto()
    {
        RtnCode = true;

        RtnMsg = "";

        RtnNum = ReturnEnum.Ok;
    }

    /// <summary>回傳碼與回傳碼預設訊息</summary>
    /// <param name="result">回傳碼</param>
    public ResultModelDto(bool result, string message = "", ReturnEnum rtnNum = ReturnEnum.Ok)
    {
        RtnCode = result;

        RtnMsg = message;

        RtnNum = rtnNum;
    }

    /// <summary>回傳碼</summary>
    public bool RtnCode { get; set; }

    /// <summary>回傳訊息</summary>
    public string RtnMsg { get; set; }

    public ReturnEnum RtnNum { get; set; }
}

/// <summary>須用到Model</summary>
public class ResultModelDto<T> : ResultModelDto
{
    /// <summary>回傳碼與回傳碼預設訊息</summary>
    public ResultModelDto() : base() { }

    /// <summary></summary>
    /// <param name="result"></param>
    /// <param name="message"></param>
    public ResultModelDto(bool result, string message, ReturnEnum rtnNum = ReturnEnum.Ok) : base(result, message, rtnNum)
    {

    }

    /// <summary>回傳資料，回傳碼與自訂訊息</summary>
    /// <param name="info"></param>
    /// <param name="result"></param>
    public ResultModelDto(T info, bool result, string message, ReturnEnum rtnNum = ReturnEnum.Ok) : base(result, message, rtnNum)
    {
        Info = info;
    }

    /// <summary>回傳資料</summary>
    public T Info { get; set; }
}