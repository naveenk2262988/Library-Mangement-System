using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Admin
{
        public interface IAdminService
        {
            Admin GetAdminById(int adminId);
            Admin GetAdminByEmail(string email);
            IEnumerable<Admin> GetAllAdmins();
            bool LoginAdmin(string email, string password);
            void UpdateAdmin(Admin admin);
            void DeleteAdmin(int adminId);
        }
    }

}
