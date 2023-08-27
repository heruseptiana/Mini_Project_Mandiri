using DataNasabah.Models;

namespace DataNasabah.Dtos
{
  public class NasabahDto
  {
    public int Id { get; set; }
    public string? NIK { get; set; }
    public string? Nama { get; set; }
    public string? NoHP { get; set; }
    public string? Email { get; set; }

    public List<AlamatNasabahDto> AlamatNasabah
    {
      get; set;
    }
  }
}
