using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestionDeVehiculos.Data;
using GestionDeVehiculos.Models;
using GestionDeVehiculos.ViewModels;
using Microsoft.AspNetCore.Hosting;
using System.IO;


namespace GestionDeVehiculos.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;
   
        private readonly IHostingEnvironment hostingEviroment;

        public MoviesController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            this.hostingEviroment = hostingEnvironment;
        }

        // GET: Movies
        public async Task<IActionResult> Index()
        {
           


            var MoviesList = new List<MoviesView>();
            var movies = await _context.movies.ToListAsync();
            foreach (var item in movies)
            {
                var MovieT = new MoviesView()
                {
                    Id = item.Id,
                    Nombre = item.Nombre,
                    Url = item.Url,
                    Sipnosis = item.Sipnosis,
                    FotoPath = item.Foto
                   
                };

                MoviesList.Add(MovieT);

            }
            return View(MoviesList);
        }

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.movies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            var MovieT = new MoviesView()
            {
                Id = movie.Id,
                Nombre = movie.Nombre,
                Url = movie.Url,
                Sipnosis = movie.Sipnosis,
          
                FotoPath = movie.Foto
               
            };

            return View(MovieT);
        }

      
        

        // GET: Movies/Create
        public IActionResult Create()
        {

            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( MoviesView MovieT)
        {
            if (ModelState.IsValid)
            {
                string uniqueName = "";

                if (MovieT.Foto != null)
                {
                    var path = Path.Combine(hostingEviroment.WebRootPath, "img/Movie");

                    uniqueName = Guid.NewGuid().ToString() + "_" + MovieT.Foto.FileName;

                    var filePath = Path.Combine(path, uniqueName);

                    if (filePath != null)
                    {
                        MovieT.Foto.CopyTo(new FileStream(filePath, mode: FileMode.Create));
                    }
                }

                var movie = new Movie()
                {
                    Id = MovieT.Id,
                    Nombre = MovieT.Nombre,
                    Url = MovieT.Url,
                    Sipnosis = MovieT.Sipnosis,
                   
                    Foto = uniqueName
                 
                };

                _context.Add(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(MovieT);
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
           

            var MovieT = new MoviesView()
            {
                Id = movie.Id,
                Nombre = movie.Nombre,
                Url = movie.Url,
                Sipnosis = movie.Sipnosis,
               
                FotoPath = movie.Foto
              
            };
            return View(MovieT);
        }



        // POST: Movies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,MoviesView MovieT)
        {
            if (id != MovieT.Id)
            {
                return NotFound();
            }

            var MovieUpdate = await _context.movies.FirstOrDefaultAsync(x => x.Id == MovieT.Id);


            if (MovieUpdate == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                string uniqueName = "";

                if (MovieT.Foto != null)
                {
                    var path = Path.Combine(hostingEviroment.WebRootPath, "img/Movie");

                    uniqueName = Guid.NewGuid().ToString() + "_" + MovieT.Foto.FileName;

                    var filePath = Path.Combine(path, uniqueName);

                    var filePathDelete = Path.Combine(path, MovieUpdate.Foto);

                    if (!string.IsNullOrEmpty(MovieUpdate.Foto))
                    {
                        if (System.IO.File.Exists(filePathDelete))
                        {
                            var fileInfo = new System.IO.FileInfo(filePathDelete);
                            fileInfo.Delete();
                        }
                    }


                    if (filePath != null)
                    {
                        MovieT.Foto.CopyTo(new FileStream(filePath, mode: FileMode.Create));
                    }
                }

                MovieUpdate.Id = MovieT.Id;
                MovieUpdate.Nombre = MovieT.Nombre;
                MovieUpdate.Url = MovieT.Url;
                MovieUpdate.Sipnosis = MovieT.Sipnosis;
             
                MovieUpdate.Foto = uniqueName;
       
                try
                {
                    _context.Update(MovieUpdate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(MovieUpdate.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", "Home");
            }
            return View(MovieT);
        }

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.movies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie = await _context.movies.FindAsync(id);
            _context.movies.Remove(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        private bool MovieExists(int id)
        {
            return _context.movies.Any(e => e.Id == id);
        }
    }
}
