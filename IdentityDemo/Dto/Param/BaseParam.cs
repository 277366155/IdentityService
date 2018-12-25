namespace Dto
{
    /// <summary>
    /// 请求参数基类
    /// </summary>
    public class BaseParam : IBaseSign
    {
        public string Key { get ; set; }
        public string Sign { get ; set; }
    }
}
