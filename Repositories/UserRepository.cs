using Microsoft.AspNetCore.Identity;
using MinimalJwt.Models;

namespace MinimalJwt.Repositories
{
    public class UserRepository
    {
        public static List<User> Users = new()
        {
            new(){Username="atacan_admin",EmailAddress="alogluatacan@gmail.com",Password="mypassword",GivenName="Atacan",Surname="Aloglu",Role="Administrator"},
            new(){Username="mete_standard",EmailAddress="metehan@gmail.com",Password="mypassword",GivenName="Metehan",Surname="Karahaliloz",Role="Standard"},
        };
    }
}
