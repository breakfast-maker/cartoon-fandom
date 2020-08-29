using AutoMapper;
using fandom.Model;
using fandom.Model.Models;
using fandom.Model.Requests;
using fandom.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace fandom.WebAPI.Services
{
    public class UsersService : IUsersService
    {
        private readonly AppCtx _ctx;
        private readonly IMapper _mapper;

        public UsersService(AppCtx context, IMapper mapper)
        {
            _ctx = context;
            _mapper = mapper;
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public MUser Authenticiraj(string username, string pass)
        {
            var user = _ctx.Users.FirstOrDefault(x => x.Username == username);

            if (user != null)
            {
                var hashedPass = GenerateHash(user.PasswordSalt, pass);

                if (hashedPass == user.PasswordHash)
                {
                    return _mapper.Map<MUser>(user);
                }
            }

            return null;
        }

        public List<MUser> Get() {

            var list = _ctx.Users.Select(x => new MUser {
                Id = x.Id,
                Email = x.Email,
                Username = x.Username,
                Roles = x.UsersRoles.Where(y => y.UserId==x.Id).Select(y => new MRole { Id = y.Role.Id, Name = y.Role.Name }).ToList()
            }).ToList();

            return list;
        }

        public MUser InsertUser(UserInsertRequest request)
        {
            var user = _mapper.Map<User>(request);

            user.PasswordSalt = GenerateSalt();
            user.PasswordHash = GenerateHash(user.PasswordSalt, request.Password);

            _ctx.Users.Add(user);

            _ctx.SaveChanges();

            foreach(var items in request.RolesId)
            {
                var userRole = new UserRole { RoleId = items, UserId = user.Id };
                _ctx.UserRoles.Add(userRole);
            }

            _ctx.SaveChanges();

            return _mapper.Map<MUser>(user);
        }
    }
}
