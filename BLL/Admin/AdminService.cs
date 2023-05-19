using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Admin
{
        public class AdminService : IAdminService
        {
            private readonly IAdminRepository _adminRepository;

            public AdminService(IAdminRepository adminRepository)
            {
                _adminRepository = adminRepository;
            }

            public Admin GetAdminById(int adminId)
            {
                return _adminRepository.GetAdminById(adminId);
            }

            public Admin GetAdminByEmail(string email)
            {
                return _adminRepository.GetAdminByEmail(email);
            }

            public IEnumerable<Admin> GetAllAdmins()
            {
                return _adminRepository.GetAllAdmins();
            }

            public bool LoginAdmin(string email, string password)
            {
                // Perform any necessary validation or business logic before logging in the admin

                // Call the repository method to authenticate the admin
                return _adminRepository.LoginAdmin(email, password);
            }

            public void UpdateAdmin(Admin admin)
            {
                // Perform any necessary validation or business logic before updating the admin

                // Call the repository method to update the admin
                _adminRepository.UpdateAdmin(admin);
            }

            public void DeleteAdmin(int adminId)
            {
                // Perform any necessary validation or business logic before deleting the admin

                // Call the repository method to delete the admin
                _adminRepository.DeleteAdmin(adminId);
            }
        }
    

}
