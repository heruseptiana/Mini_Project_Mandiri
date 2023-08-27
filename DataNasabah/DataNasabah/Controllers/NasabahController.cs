using AutoMapper;
using DataNasabah.Dtos;
using DataNasabah.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DataNasabah.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class NasabahController : ControllerBase
  {
    private readonly NasabahDbContext _nasabahDbContext;
    private readonly IMapper _mapper;

    public NasabahController(NasabahDbContext nasabahDbContext, IMapper mapper) 
    {
      _nasabahDbContext = nasabahDbContext;
      _mapper = mapper;
    }

    //Select semua Data Nasabah
    [HttpGet]
    public async Task<IActionResult> Get()
    {
      var Nasabah = await _nasabahDbContext.Nasabah
        .Include(_ => _.AlamatNasabah).ToListAsync();
      return Ok(Nasabah);
    }

    //Select Data by Id
    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> Get(int id)
    {
      var Nasabah = await _nasabahDbContext.Nasabah
        .Include(_ => _.AlamatNasabah).Where(_ => _.Id == id).FirstOrDefaultAsync();
      return Ok(Nasabah);
    }

    //Insert Data
    [HttpPost]
    public async Task<IActionResult> Post(NasabahDto nasabah)
    {
      var newNasabah = _mapper.Map<Nasabah>(nasabah);
      _nasabahDbContext.Nasabah.Add(newNasabah);
      await _nasabahDbContext.SaveChangesAsync();
      return Created($"/nasabah/{newNasabah.Id}", newNasabah);
    }

    //Uodate Data
    [HttpPut]
    public async Task<IActionResult> Put(NasabahDto nasabah)
    {
      var updateNasabah = _mapper.Map<Nasabah>(nasabah);
      _nasabahDbContext.Nasabah.Update(updateNasabah);
      await _nasabahDbContext.SaveChangesAsync();
      return Ok(updateNasabah);
    }

    //Hapus Data
    [HttpDelete]
    [Route("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
      var NasabahToDelete = await _nasabahDbContext.Nasabah
        .Include(_ => _.AlamatNasabah).Where(_ => _.Id == id).FirstOrDefaultAsync();
      if (NasabahToDelete == null) 
      {
        return NotFound();
      }

      _nasabahDbContext.Nasabah.Remove(NasabahToDelete);
      await _nasabahDbContext.SaveChangesAsync();
      return NoContent();
    }
  }
}
