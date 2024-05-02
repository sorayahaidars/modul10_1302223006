using Microsoft.AspNetCore.Mvc;

namespace modul10_1302223006.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        public static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Soraya Haidar Salma", "1302223006", new List<string> { "KPL", "Basis Data" }, 2024),
            new Mahasiswa("Muhammad Fauzan Majid", "1302220144", new List<string> { "KPL", "Basis Data" }, 2024),
            new Mahasiswa("Arinza Aurelvia", "1302220022", new List<string> { "KPL", "Basis Data"}, 2024),
            new Mahasiswa("Muhammada Daffa Fadillah", "1302223124", new List<string> { "KPL", "Basis Data" }, 2024),
            new Mahasiswa("Muhammad Hashfi Hadyan", "1302220079", new List<string> { "KPL", "Basis Data"}, 2024),
            new Mahasiswa("Maulana Farras", "1302223333", new List<string> { "KPL", "Basis Data"}, 2024)
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMahasiswa;
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa newvalue)
        {
            dataMahasiswa.Add(newvalue);
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMahasiswa[id];
        }

        [HttpDelete("{id}")] 
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}

