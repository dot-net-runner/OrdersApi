using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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


        public static ApiResponse<T> Success(T data)
        {
            return new ApiResponse<T>(200, null, data);
        }
    }
}
