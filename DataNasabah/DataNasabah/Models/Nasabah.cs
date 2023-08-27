namespace DataNasabah.Models
{
  public class Nasabah
  {
    public int Id { get; set; }
    public string? NIK { get; set; }
    public string? Nama { get; set; }
    public string? NoHP { get; set; }
    public string? Email { get; set; }
    public List<AlamatNasabah> AlamatNasabah
    {
      get; set;
    }
  }
}
