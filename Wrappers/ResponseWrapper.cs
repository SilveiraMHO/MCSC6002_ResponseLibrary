using ResponseLibrary.Wrappers.Interfaces;

namespace ResponseLibrary.Wrappers
{
    public class ResponseWrapper : IResponseWrapper
    {
        public List<string> Messages { get; set; } = [];
        public bool IsSuccessful { get; set; }

        #region Fail Synchronously
        public static ResponseWrapper Fail()
        {
            return new ResponseWrapper() { IsSuccessful = false };
        }

        public static ResponseWrapper Fail(string message)
        {
            return new ResponseWrapper() { IsSuccessful = false, Messages = [message] };
        }

        public static ResponseWrapper Fail(List<string> messages)
        {
            return new ResponseWrapper() { IsSuccessful = false, Messages = messages };
        }
        #endregion

        #region Fail Asynchronously
        public static Task<ResponseWrapper> FailAsync()
        {
            return Task.FromResult(Fail());
        }

        public static Task<ResponseWrapper> FailAsync(string message)
        {
            return Task.FromResult(Fail(message));
        }

        public static Task<ResponseWrapper> FailAsync(List<string> messages)
        {
            return Task.FromResult(Fail(messages));
        }
        #endregion

        #region Success Synchronously
        public static ResponseWrapper Success()
        {
            return new ResponseWrapper() { IsSuccessful = true };
        }

        public static ResponseWrapper Success(string message)
        {
            return new ResponseWrapper() { IsSuccessful = true, Messages = [message] };
        }

        public static ResponseWrapper Success(List<string> messages)
        {
            return new ResponseWrapper() { IsSuccessful = true, Messages = messages };
        }
        #endregion

        #region Success Asynchronously
        public static Task<ResponseWrapper> SuccessAsync()
        {
            return Task.FromResult(Success());
        }

        public static Task<ResponseWrapper> SuccessAsync(string message)
        {
            return Task.FromResult(Success(message));
        }

        public static Task<ResponseWrapper> SuccessAsync(List<string> messages)
        {
            return Task.FromResult(Success(messages));
        }
        #endregion
    }

    public class ResponseWrapper<T> : ResponseWrapper, IResponseWrapper<T>
    {
        public T Data { get; set; }

        #region Fail Synchronously
        public new static ResponseWrapper<T> Fail()
        {
            return new ResponseWrapper<T>() { IsSuccessful = false };
        }
        public new static ResponseWrapper<T> Fail(string message)
        {
            return new ResponseWrapper<T>() { IsSuccessful = false, Messages = [message] };
        }
        public new static ResponseWrapper<T> Fail(List<string> messages)
        {
            return new ResponseWrapper<T>() { IsSuccessful = false, Messages = messages };
        }
        #endregion

        #region Fail Asynchronously
        public new static Task<ResponseWrapper<T>> FailAsync()
        {
            return Task.FromResult(Fail());
        }
        public new static Task<ResponseWrapper<T>> FailAsync(string message)
        {
            return Task.FromResult(Fail(message));
        }
        public new static Task<ResponseWrapper<T>> FailAsync(List<string> messages)
        {
            return Task.FromResult(Fail(messages));
        }
        #endregion

        #region Success Synchronously
        public new static ResponseWrapper<T> Success()
        {
            return new ResponseWrapper<T>() { IsSuccessful = true };
        }
        public new static ResponseWrapper<T> Success(string message)
        {
            return new ResponseWrapper<T>() { IsSuccessful = true, Messages = [message] };
        }
        public new static ResponseWrapper<T> Success(List<string> messages)
        {
            return new ResponseWrapper<T>() { IsSuccessful = true, Messages = messages };
        }
        public static ResponseWrapper<T> Success(T data)
        {
            return new ResponseWrapper<T>() { IsSuccessful = true, Data = data };
        }
        public static ResponseWrapper<T> Success(T data, string message)
        {
            return new ResponseWrapper<T>() { IsSuccessful = true, Data = data, Messages = [message] };
        }
        public static ResponseWrapper<T> Success(T data, List<string> messages)
        {
            return new ResponseWrapper<T>() { IsSuccessful = true, Data = data, Messages = messages };
        }
        #endregion

        #region Success Asynchronously
        public new static Task<ResponseWrapper<T>> SuccessAsync()
        {
            return Task.FromResult(Success());
        }
        public new static Task<ResponseWrapper<T>> SuccessAsync(string message)
        {
            return Task.FromResult(Success(message));
        }
        public new static Task<ResponseWrapper<T>> SuccessAsync(List<string> messages)
        {
            return Task.FromResult(Success(messages));
        }
        public static Task<ResponseWrapper<T>> SuccessAsync(T data)
        {
            return Task.FromResult(Success(data));
        }
        public static Task<ResponseWrapper<T>> SuccessAsync(T data, string message)
        {
            return Task.FromResult(Success(data, message));
        }
        public static Task<ResponseWrapper<T>> SuccessAsync(T data, List<string> messages)
        {
            return Task.FromResult(Success(data, messages));
        }
        #endregion
    }
}
