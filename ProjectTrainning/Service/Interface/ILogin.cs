using ProjectTrainning.DTO;
using ProjectTrainning.Models.Requests.Params;

namespace ProjectTrainning.Service.Interface
{
    interface ILogin
    {
        UserDTO Authenticate(UserRequest request);
    }
}
