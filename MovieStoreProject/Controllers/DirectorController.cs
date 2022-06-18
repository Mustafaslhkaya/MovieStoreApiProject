using Microsoft.AspNetCore.Mvc;
using MovieStoreProject.DataAccess;
using MovieStoreProject.Entities;
using MovieStoreProject.Models.DirectorModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieStoreProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DirectorController : ControllerBase
    {
        private readonly Context _context;


        public DirectorController(Context context)
        {
            _context = context;
        }
        
        
        [HttpGet]
        public List<GetDirectorsModel> GetDirectorList()
        {
            var directorList = _context.Directors.OrderBy(x => x.DirectorId).ToList<Director>();
            List<GetDirectorsModel> modellist=new List<GetDirectorsModel>();
            foreach (var director in directorList)
            {
                modellist.Add(new GetDirectorsModel
                {
                    DirectorName = director.DirectorName,
                    DirectorSurname = director.DirectorSurname,
                });
            }
            return modellist;

        }
        
        
        [HttpPost]
        public void AddDirector([FromBody] GetDirectorsModel model)
        {
            var director = _context.Directors.FirstOrDefault(x => x.DirectorName == model.DirectorName);
            if (director is not null)
            {
                throw new InvalidOperationException("Yönetmen zaten mevcut.");

            }
            director = new Director();
            director.DirectorName = model.DirectorName;
            director.DirectorSurname = model.DirectorSurname;
            _context.Directors.Add(director);
            _context.SaveChanges();
        }

        [HttpPut]
        public void UpdateDirector([FromBody] UpdateDirectorModel model)
        {
            var director = _context.Directors.FirstOrDefault(x => x.DirectorId == model.DirectorId);
            if (director is null)
            {
                throw new InvalidOperationException("Yönetmen mevcut değil");

            }
            director.DirectorName = model.DirectorName != default ? model.DirectorName : director.DirectorName;
            director.DirectorSurname = model.DirectorSurname != default ? model.DirectorSurname : director.DirectorSurname;
            _context.SaveChanges();
        }

        [HttpDelete]
        
        public void DeleteDirector(int id)
        {
            var director=_context.Directors.FirstOrDefault(x => x.DirectorId == id);
            if (director is null)
            {
                throw new InvalidOperationException("Böyle bir yönetmen zaten yok.");
            }
            _context.Directors.Remove(director);
            _context.SaveChanges();
        }
    }


}
