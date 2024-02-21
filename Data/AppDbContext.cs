using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityManager.Data;

public class AppDbContext(DbContextOptions options): IdentityDbContext(options)
{
    
}