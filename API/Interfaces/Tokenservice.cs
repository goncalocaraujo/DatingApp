using API.Entities;

namespace API.Interfaces
{
    public interface Tokenservice
    {
         string CreateToken(AppUser user);
         
    }
}