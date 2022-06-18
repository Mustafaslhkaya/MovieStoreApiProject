using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MovieStoreProject.DataAccess;
using MovieStoreProject.Entities;
using MovieStoreProject.Models.ActorModels;

using System;
using System.Collections.Generic;
using System.Linq;


namespace MovieStoreProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActorController : ControllerBase
    {
        private readonly Context _context;
        private readonly IMapper _mapper;

        public ActorController(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpGet]
        public List<GetActorModel> GetActorList()
        {
            var actorlist = _context.Actors.OrderBy(x => x.ActorId).ToList<Actor>();
            List<GetActorModel> modellist= new List<GetActorModel>();
            foreach (var actor in actorlist)
            {
                modellist.Add(new GetActorModel()
                {
                    ActorName = actor.ActorName,
                    ActorSurname=actor.ActorSurname
                });
            }
            return modellist;
        }


        [HttpPost]
        public void AddActor([FromBody]AddActorModel model)
        {
            var actor = _context.Actors.FirstOrDefault(x => x.ActorName == model.ActorName);
            if (actor is not null)
            {
                throw new InvalidOperationException("Aktör zaten mevcut");
            }
            actor = _mapper.Map<Actor>(model); /*new Actor();*/
            //actor.ActorName = model.ActorName;
            //actor.ActorSurname = model.ActorSurname;
            _context.Actors.Add(actor);
            _context.SaveChanges();
            
        }


        [HttpPut]
        public void UpdateActor([FromBody] UpdateActorModel model)
        {
            var actor = _context.Actors.FirstOrDefault(x => x.ActorId == model.ActorId);
            if (actor is null)
            {
                throw new InvalidOperationException("Böyle bir aktör bulunamadı.");
            }
            actor.ActorName = model.ActorName != default ? model.ActorName : actor.ActorName;
            actor.ActorSurname = model.ActorSurname != default ? model.ActorSurname : actor.ActorSurname;
            _context.SaveChanges();

        }


        [HttpDelete]
        public void DeleteActor(int id)
        {
            
            var actor = _context.Actors.FirstOrDefault(x => x.ActorId==id);
            if (actor is null)
            {
                throw new InvalidOperationException("Böyle bir aktör bulunamadı.");
            }
            _context.Actors.Remove(actor);
            _context.SaveChanges();

        }

    }
}
