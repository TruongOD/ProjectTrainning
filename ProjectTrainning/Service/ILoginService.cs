using Microsoft.EntityFrameworkCore;
using ProjectTrainning.DTO;
using ProjectTrainning.Models.Requests.Params;
using ProjectTrainning.Service.Interface;

namespace ProjectTrainning.Service
{
    public class LoginService
    {
        private readonly MyprojectDBContext _context;

        public LoginService(MyprojectDBContext context)
        {
            _context = context;
        }

        public UserDTO Authenticate(UserRequest request)
        {
            //var entity = _context.Users.FirstOrDefaultAsync(x=> x.Name == request.Name && x.);
            return null;
        }
    }
}