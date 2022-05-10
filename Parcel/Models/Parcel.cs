namespace Parcel.Models
{
  public class ParcelItem
  {
    public double Height { get; set; }
    public double Width { get; set; }
    public double Length { get; set; }
    public double Weight { get; set; }
    public ParcelItem(double height, double width, double length, double weight) 
    {
      Height = height;
      Width = width;
      Length = length;
      Weight = weight;
    }
    public double Volume()
    {
      return (Height * Width * Length) + Weight;
    }
    public double CalculateCost()
    {
      double volume = Volume();
      return volume/5;
    }
  }
}