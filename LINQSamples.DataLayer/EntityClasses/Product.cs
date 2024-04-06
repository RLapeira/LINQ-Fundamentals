using System.Text;

namespace LINQSamples
{
  public partial class Product
  {
    public int ProductID { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public decimal StandardCost { get; set; }
    public decimal ListPrice { get; set; }
    public string Size { get; set; }

    // Calculated Properties
    public int? NameLength { get; set; }
    public decimal? TotalSales { get; set; }

    #region ToString Override 
    public override string ToString()
    {
      StringBuilder sb = new(1024);

      sb.AppendLine($"{Name}  ID: {ProductID}");
      sb.AppendLine($"   Color: {Color}   Size: {(Size ?? "n/a")}");
      sb.AppendLine($"   Cost: ${StandardCost:n}   Price: ${ListPrice:n}");
      if (NameLength.HasValue)
      {
        sb.AppendLine($"   Name Length: {NameLength}");
      }
      if (TotalSales.HasValue)
      {
        sb.AppendLine($"   Total Sales: ${TotalSales:n}");
      }
      return sb.ToString();
    }
    #endregion
  }
}
