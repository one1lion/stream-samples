using EfCorePaging.Shared.PagerModels;
using EfCorePaging.Shared.ServicesInterfaces;
using EfCorePaging.Shared.ToppingInfoModels;
using Microsoft.EntityFrameworkCore;
using SomeTaco.Database;
using SomeTaco.Models;

namespace EfCorePaging.SharedServer.Services {
  public class TacoService : ITacoService {
    private readonly SomeTacoContext _context;

    public TacoService(SomeTacoContext context) {
      _context = context;
    }

    public async Task<ToppingInfo> GetToppings(PagerInfo pagerInfo, CancellationToken ct = default) {
      var forRet = new ToppingInfo() { PagerInfo = pagerInfo };
      try {
        ct.ThrowIfCancellationRequested();
        var toppingQuery = _context.Toppings.AsNoTracking();

        // TODO: Implement order stuff in PagerInfo
        toppingQuery = toppingQuery.OrderBy(x => x.Id);

        // Adjust the PageSize and current page number to fit constraints
        pagerInfo.PageSize = Math.Clamp(pagerInfo.PageSize, 10, 20); // Page size between 10 and 20 records

        // Recalculate total record count
        pagerInfo.TotalRecordCount = await toppingQuery.CountAsync(ct);

        // Early out if no records:
        if (pagerInfo.TotalRecordCount == 0) {
          return forRet;
        }

        // Adjust requested PageNum to fit between 1 and TotalPageCount
        pagerInfo.PageNum = Math.Clamp(pagerInfo.PageNum, 1, Math.Max(pagerInfo.TotalPageCount, 1));

        toppingQuery = toppingQuery.Skip((pagerInfo.PageNum - 1) * pagerInfo.PageSize).Take(pagerInfo.PageSize);

        forRet.CurrentToppingsList = await toppingQuery.ToListAsync(ct);
        return forRet;
      } catch (OperationCanceledException) {
        // User is allowed to cancel before this completes
        return forRet;
      } catch (Exception) {
        throw;
      }
    }
  }
}
