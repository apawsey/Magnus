using System;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext{

    public ApplicationDbContext()
    { }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    { }
    public DbSet<User> Users { get; set; }
}

public class User
{
    protected User()
    {

    }

    public User(string userId)
    {
        UserId = userId;
        InternalUserId = Guid.NewGuid().ToString();
    }

    public string UserId { get; set; }
    public string InternalUserId { get; set; }
}