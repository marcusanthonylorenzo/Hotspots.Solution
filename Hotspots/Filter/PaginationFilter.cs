using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hotspots.Filter
{
  public class PaginationFilter
  {
      public int PageNumber { get; set; }
      public int PageSize { get; set; }
      public PaginationFilter()
      {
          this.PageNumber = 1;
          this.PageSize = 10;
      }
      public PaginationFilter(int pageNumber, int pageSize)
      {
          this.PageNumber = pageNumber < 1 ? 1 : pageNumber;
          this.PageSize = pageSize > 10 ? 10 : pageSize;
      }
  }

}