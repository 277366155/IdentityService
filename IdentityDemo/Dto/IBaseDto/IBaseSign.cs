using System;
using System.Collections.Generic;
using System.Text;

namespace Dto
{
    public  interface  IBaseSign
    {
      string Key { get; set; }

      string Sign { get; set; }
    }
}
