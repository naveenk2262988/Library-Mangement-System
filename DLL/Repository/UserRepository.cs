//using DAL.Models;
//using DAL.Data;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using DAL.Repository.Interface;

//namespace DAL.Repository

//{
//        public class UserRepository : IUser
//        {
//            private readonly DatabaseContext _context;

//            public UserRepository(DatabaseContext context)
//            {
//                _context = context;
//            }

//            public IEnumerable<User> GetAll()
//            {
//                return _context.Users.ToList();
//            }

//            public User GetById(int id)
//            {
//                return _context.Users.Find(id);
//            }

//            public void Add(User user)
//            {
//                _context.Users.Add(user);
//                _context.SaveChanges();
//            }

//            public void Update(User user)
//            {
//                _context.Users.Update(user);
//                _context.SaveChanges();
//            }

//            public void Delete(User user)
//            {
//                _context.Users.Remove(user);
//                _context.SaveChanges();
//            }
//        }
//}


