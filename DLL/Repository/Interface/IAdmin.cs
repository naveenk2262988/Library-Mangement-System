using DAL.Models;
using DAL.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Repository.Interface
{
    public interface IAdmin
    {
        IEnumerable<Admin> GetAll();
        Admin GetById(int id);
        void Add(Admin admin);
        void Update(Admin admin);
        void Delete(Admin admin);
        int RegisterAdmin(AdminDTO adminDTO);
    }
}
