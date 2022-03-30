using CsvHelper.Configuration;

namespace EfCorePaging.Shared.FloatTableModels {
  public class FloatTableViewModel {
    public DateOnly DatePart { get; set; }
    public TimeOnly TimePart { get; set; }
    public short Millitm { get; set; }
    public short TagIndex { get; set; }
    public double Val { get; set; }
    public string? SomeString { get; set; }
    public string? SomeString2 { get; set; }
  }

  public sealed class FloatTableViewModelMap : ClassMap<FloatTableViewModel> {
    public FloatTableViewModelMap() {
      Map(m => m.DatePart);
      Map(m => m.TimePart);
      Map(m => m.Millitm);
      Map(m => m.TagIndex);
      Map(m => m.Val);
      Map(m => m.SomeString);
      Map(m => m.SomeString2);
    }
  }
}
