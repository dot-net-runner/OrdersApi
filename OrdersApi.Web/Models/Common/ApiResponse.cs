using System.Collections.Generic;

namespace OrdersApi.Web.Models.Common
{
    public class ApiResponse<T>
    {
        public int Code { get; private set; }

        public IReadOnlyDictionary<string, string>? Errors { get; private set; }

        public T Data { get; private set; }


        public ApiResponse(int code, IReadOnlyDictionary<string, string>? errors, T data)
        {
            Code = code;
            Errors = errors;
            Data = data;
        }

        public ApiResponse(int code, string error, string message)
            : this(code, new Dictionary<string, string> { { error, message } })
        {
        }

        public ApiResponse(int code, IReadOnlyDictionary<string, string> errors)
        {
            Code = code;
            Errors = errors;
        }

        public static ApiResponse<T> Success(T data)
        {
            return new ApiResponse<T>(200, null, data);
        }
    }
}
