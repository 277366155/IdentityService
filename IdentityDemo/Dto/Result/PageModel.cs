﻿using System.Collections.Generic;

namespace Dto
{
    public  class PageModel<T>
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int Total { get; set; }
        
        public List<T> Data { get; set; }
    }
}
