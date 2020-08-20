using AutoMapper;
using fandom.Model;
using fandom.Model.Requests;
using fandom.Model.Requests.Character;
using fandom.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace fandom.WebAPI.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly AppCtx _ctx;
        private readonly IMapper _mapper;

        public CharacterService(AppCtx context, IMapper mapper)
        {
            _ctx = context;
            _mapper = mapper;
        }

        public List<MCharacter> Get()
        {
            var characters = _ctx.Characters.Include(x => x.CharacterMediaFile).ToList();

            return _mapper.Map<List<MCharacter>>(characters);
        }

        public MCharacter GetById(int id)
        {
            var character = _ctx.Characters.Include(x => x.CharacterMediaFile).Where(x => x.Id == id).SingleOrDefault();
            return _mapper.Map<MCharacter>(character);
        }

        public MCharacter Insert(CharacterInsert request)
        {
            var NewCharacter = _mapper.Map<Character>(request);

            NewCharacter.CharacterMediaFile = _mapper.Map<CharacterMediaFile>(request.MediaFile);
            

            _ctx.Characters.Add(NewCharacter);
            _ctx.SaveChanges();

            return _mapper.Map<MCharacter>(NewCharacter);
        }

    }
}
