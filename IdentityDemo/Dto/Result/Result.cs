namespace Dto
{
    public  class Result<T>
    {
        public ResultCodeEnum Code { get; set; }
        public T Data { get; set; }
        public string Msg { get; set; }
    }

    public enum ResultCodeEnum
    {
        Ok=200,
        Error=500
    }
}
