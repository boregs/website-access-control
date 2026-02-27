using Microsoft.EntityFrameworkCore;
using backend.Models;

namespace backend.Data
{
    public class DAO : DbContext
    {
        public DAO(DbContextOptions<DAO> options) : base(options){ }
        public DbSet<UserModel> Users { get; set; } = null!;
    }
}
