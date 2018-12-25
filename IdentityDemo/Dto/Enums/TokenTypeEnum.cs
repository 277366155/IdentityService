namespace Dto
{
    public  enum TokenTypeEnum
    {
        /// <summary>
        /// 有效期内可用
        /// </summary>
        ShortLived=0,
        /// <summary>
        /// 永久有效
        /// </summary>
        Permanent,
        /// <summary>
        /// 一次性使用
        /// </summary>
        SingleUse
    }
}
