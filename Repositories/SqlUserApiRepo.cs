using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Solution.Interfaces;
using Solution.Datas.Contexts;
using Solution.Models;
using System.Xml.Linq;

namespace Solution.Repositories
{
    public class SqlUserApiRepo : IUserApiRepo
    {
        private readonly ApplicationDbContext _context; 

        public SqlUserApiRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateUser(UserModel user)
        {
            if(user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            await _context.Users.AddAsync(user);
        }

        public void DeleteUser(UserModel user)
        {
            if(user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            _context.Users.Remove(user);
        }

        public async Task<IEnumerable<UserModel>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<UserModel> GetUserById(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(user => user.Id == id);
        }

        public async Task UpdateUser(UserModel user)
        {
            ///
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() >= 0;
        }
    }
}