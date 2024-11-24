using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace UT03_04WebApiJWT.Auth
{
    public class JWTAuthContext : IdentityDbContext<IdentityUser>
    {

            public JWTAuthContext(DbContextOptions<JWTAuthContext> options) : base(options)
            {
            }
            protected override void OnModelCreating(ModelBuilder builder)
            {
            //Creacion de Roles
            List<IdentityRole> Rols = new List<IdentityRole>()
            {
            new IdentityRole {Name = "Basic", NormalizedName = "BASIC"},
            new IdentityRole {Name = "Admin", NormalizedName = "ADMIN"}
            };
            builder.Entity<IdentityRole>().HasData(Rols);
            //Creacion de Usuarios
            List<IdentityUser> Users = new List<IdentityUser>()
        {
            new IdentityUser {
                UserName = "basic@ejercicio4.com",
                NormalizedUserName = "BASIC@EJERCICIO4.COM",
                Email = "basic@ejercicio4.com",
                NormalizedEmail = "BASIC@EJERCICIO4.COM"
            },
            new IdentityUser {
                UserName = "admin@ejercicio4.com",
                NormalizedUserName = "ADMIN@EJERCICIO4.COM",
                Email = "admin@ejercicio4.com",
                NormalizedEmail = "ADMIN@EJERCICIO4.COM"
            }
        };
            builder.Entity<IdentityUser>().HasData(Users);
            //Asignacion de contraseÃ±a de cada usuario
            var passwordHasher = new PasswordHasher<IdentityUser>();
            Users[0].PasswordHash = passwordHasher.HashPassword(Users[0], "Basic123!");
            Users[1].PasswordHash = passwordHasher.HashPassword(Users[1], "Admin123!");
            //Asignacion de roles por defecto de cada usuario
            List<IdentityUserRole<string>> userRol = new List<IdentityUserRole<string>>();
            userRol.Add(new IdentityUserRole<string>
            {
                UserId = Users[0].Id,
                RoleId = Rols[0].Id
            });
            userRol.Add(new IdentityUserRole<string>
            {
                UserId = Users[1].Id,
                RoleId = Rols[1].Id
            });

            builder.Entity<IdentityUserRole<string>>().HasData(userRol);
            base.OnModelCreating(builder);

        }
    }
    }