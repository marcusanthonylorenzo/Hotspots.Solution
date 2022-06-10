using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hotspots.Models;
using Hotspots.Filter;
using Hotspots.Services;
using Hotspots.Wrappers;

namespace Hotspots.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class RestaurantsController : ControllerBase
  {
    private readonly HotspotsContext _db;

    public RestaurantsController(HotspotsContext db)
    {
      _db = db;
    }

    // GET: https://localhost:5001/api/Restaurants
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Restaurant>>> Get(string name, string city, string cuisine)
    {
      var query = _db.Restaurants.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (city != null)
      {
        query = query.Where(entry => entry.City == city);
      }    

      if (cuisine != null)
      {
        query = query.Where(entry => entry.Cuisine == cuisine);
      }      

      return await query.ToListAsync();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] PaginationFilter filter)
    {
        var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
        var pagedData = await _db.Restaurants
            .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
            .Take(validFilter.PageSize)
            .ToListAsync();
        var totalRecords = await _db.Restaurants.CountAsync();
        return Ok(new PagedResponse<List<Restaurant>>(pagedData, validFilter.PageNumber, validFilter.PageSize));
    }

    // GET: https://localhost:5001/api/Restaurants/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<Restaurant>> GetRestaurant(int id)
    {
        var Restaurant = await _db.Restaurants.FindAsync(id);

        if (Restaurant == null)
        {
            return NotFound();
        }

        return Restaurant;
    }
    // public async Task<IActionResult> GetRestaurant(int id)
    // {
    //     var restaurant = await context.restaurants.Where(a => a.Id == id).FirstOrDefaultAsync();
    //     return Ok(new Response<Restaurant>(restaurant));
    // }



    // PUT: https://localhost:5001/api/Restaurants/{id}
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Restaurant restaurant)
    {
      if (id != restaurant.Id)
      {
        return BadRequest();
      }

      _db.Entry(restaurant).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!RestaurantExists(id))
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

    // POST: api/Restaurants
    [HttpPost]
    public async Task<ActionResult<Restaurant>> Post(Restaurant restaurant)
    {
      _db.Restaurants.Add(restaurant);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetRestaurant), new { id = restaurant.Id }, restaurant);
    }

    // DELETE: api/Restaurants/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteRestaurant(int id)
    {
      var restaurant = await _db.Restaurants.FindAsync(id);
      if (restaurant == null)
      {
        return NotFound();
      }

      _db.Restaurants.Remove(restaurant);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool RestaurantExists(int id)
    {
      return _db.Restaurants.Any(e => e.Id == id);
    }
  }
}