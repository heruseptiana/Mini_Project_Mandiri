namespace DataNasabah.Models
{
  public class AlamatNasabah
  {
    public int Id { get; set; }
    public string? Kota { get; set; }
    public string? Negara { get; set; }
    public int IdNasabah { get; set; }
    public Nasabah Nasabah { get; set; }
  }
}
