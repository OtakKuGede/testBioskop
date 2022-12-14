using Bioskop.IService;
using Bioskop.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bioskop.Service
{
    public class MsUserService : IMsUserService
    {
        BioskopContext dbContext;

        public MsUserService(BioskopContext _db)
        {
            dbContext = _db;
        }


        public List<MsUser> GetUser()
        {
            List<MsUser> user = dbContext.MsUsers.ToList();
            return user;
        }

        public MsUser RegisterUser(MsUserRequestDto req , string email)
        {
            MsUser user = dbContext.MsUsers.Find(req.Email);
            if (user == null)
            {
                if (req.Password.Length >= 8)
                {
                    MsUser users = new MsUser();
                    users.Email = req.Email;
                    users.Password = req.Password;
                    users.IdUser = Guid.NewGuid();
                    users.Kota = req.Kota;
                    users.NoTelepon = req.NoTelepon;
                    users.Alamat = req.Alamat;

                    dbContext.MsUsers.Add(users);
                    dbContext.SaveChanges();
                    return user;
                }

            }
            return null;

        }
    }
}
