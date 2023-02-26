using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackendDevIntroAPIWebApp.Models;

namespace BackendDevIntroAPIWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StagesController : ControllerBase
    {
        private readonly SiriusContext _context;

        public StagesController(SiriusContext context)
        {
            _context = context;
        }

        // GET: api/Stages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Stage>>> GetStages()
        {
            //return await _context.Stages.ToListAsync();
            var rng = new Random();
            return Enumerable.Range(1, 6).Select(index => new Stage
            {
                Id = index,
                SSE = "SSEMazara",
                Plant = "Mazara" + index,
                Device = "Mdv" + index,
                Subsystem = "WPP",
                Section = "Linea 03",
                Model = "V126",
                Serial = "pippo",
                Altitude = rng.Next(10, 30) * 10 + rng.Next(1, 99),
                Latitude = 3770000 + rng.Next(3000, 7000),
                Longitude = 1260000 + rng.Next(4000, 7000),
                Year = -1,
                DeviceType = "WTG",
                Up = "UP_PRCLCDMZRD_2",
                EcName = "Vestas_Mazara",
                Notes = "Mazara2",
                Vendor = "Vestas",
                DowntimeClass = "PRM_VESTAS",
                NominalPower = rng.Next(1, 100) * 100,
                TechAvailability = " ",
                ContrAvailability = " ",
                Municipality = " "
            })
            .ToArray();
        }

        // GET: api/Stages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Stage>> GetStage(long id)
        {
            var stage = await _context.Stages.FindAsync(id);

            if (stage == null)
            {
                return NotFound();
            }

            return stage;
        }

        // PUT: api/Stages/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStage(long id, Stage stage)
        {
            if (id != stage.Id)
            {
                return BadRequest();
            }

            _context.Entry(stage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StageExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Stages
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Stage>> PostStage(Stage stage)
        {
            _context.Stages.Add(stage);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStage", new { id = stage.Id }, stage);
        }

        // DELETE: api/Stages/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStage(long id)
        {
            var stage = await _context.Stages.FindAsync(id);
            if (stage == null)
            {
                return NotFound();
            }

            _context.Stages.Remove(stage);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StageExists(long id)
        {
            return _context.Stages.Any(e => e.Id == id);
        }
    }
}
