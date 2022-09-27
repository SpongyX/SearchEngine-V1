namespace SearchEngine.ResponseMessage
{
    public class ResponseMsg
    {
        public bool Successed { get; set; }
        public string Code { get; set; }
        public string Message { get; set; }
        public object Response { get; set; }

        private ResponseMsg(string Code, string Message, object Response = null)
        {
            this.Code = Code;
            this.Response = Response;
 
        }

        public static ResponseMsg PerformSuccess(object Response = null, string Code = null, string Message = null)
        {
            var result = new ResponseMsg(Code, Message, Response);
            result.Successed = true;
            return result;
        }
        public static ResponseMsg PerformError(string Code = null, string Message = null )
        {
            var result = new ResponseMsg(Code, Message, null);
            result.Successed = false;
            return result;
        }
    }
}
