using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hotspots.Filter;
using Hotspots.Services;

namespace Hotspots.Services
{
  public interface IUriService
  {
      public Uri GetPageUri(PaginationFilter filter, string route);
  }
}