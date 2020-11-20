namespace UsersManager.Models
{
    using Microsoft.EntityFrameworkCore;
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            :base(options)
        {

        }
    }
}
