using DAL.Models;
using DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository.Interface;
using DAL.Models.DTO;

namespace DAL.Repository
{
    public class AdminRepository : IAdmin
    {
        private readonly DatabaseContext _context;

        public AdminRepository(DatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Admin> GetAll()
        {
            return _context.Admins.ToList();
        }

        public Admin GetById(int id)
        {
            return _context.Admins.Find(id);
        }
        public int RegisterAdmin(AdminDTO adminDTO)
        {
            var domain = new Admin
            {
                AdminID = Guid.NewGuid(),
                Name = adminDTO.Name,
                Username = adminDTO.Username,
                Password = adminDTO.Password,
                Email = adminDTO.Email,
            };
            _context.Admins.Add(domain);
            int done = _context.SaveChanges();
            return done;

        }
        public void Add(Admin admin)
        {
            _context.Admins.Add(admin);
            _context.SaveChanges();
        }

        public void Update(Admin admin)
        {
            _context.Admins.Update(admin);
            _context.SaveChanges();
        }

        public void Delete(Admin admin)
        {
            _context.Admins.Remove(admin);
            _context.SaveChanges();
        }
    }
}

