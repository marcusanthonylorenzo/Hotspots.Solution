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
using Hotspots.Helpers;

namespace Hotspots.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class RestaurantsController : ControllerBase
  {
    private readonly HotspotsContext _db;
    private readonly IUriService uriService;
    public RestaurantsController(HotspotsContext db, IUriService uriService)
    {
      _db = db;
      this.uriService = uriService;
    }

    // GET: https://localhost:5001/api/Restaurants

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] PaginationFilter filter)
    {
        var route = Request.Path.Value;
        var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
        var pagedData = await _db.Restaurants
            .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
            .Take(validFilter.PageSize)
            .ToListAsync();
        var totalRecords = await _db.Restaurants.CountAsync();

        var pagedReponse = PaginationHelper.CreatePagedResponse<Restaurant>(pagedData, validFilter, totalRecords, uriService, route);
        return Ok(pagedReponse);
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

    // PUT: https://localhost:5001/api/Restaurants/{id}

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

    // POST: https://localhost:5001/api/Restaurants


    [HttpPost]
    public async Task<ActionResult<Restaurant>> Post(Restaurant restaurant)
    {
      _db.Restaurants.Add(restaurant);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetRestaurant), new { id = restaurant.Id }, restaurant);
    }

    // DELETE: https://localhost:5001/api/Restaurants/{id}
    
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