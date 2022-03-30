using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCorePaging.Shared.PagerModels; 
public class PagerInfo {
  public int PageNum { get; set; } = 1;
  public int PageSize { get; set; } = 10;

  public int TotalRecordCount { get; set; }

  public int TotalPageCount => PageSize == 0 ? 0 : (int)Math.Ceiling((decimal)TotalRecordCount / PageSize);
}
