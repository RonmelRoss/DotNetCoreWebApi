using DotNetCoreWebApi.Common.Dto;

namespace DotNetCoreWebApi.BLL.Interface;

public interface IUserService
{
    IEnumerable<UserDto> GetAll();

    UserDto GetById(Guid id);

    UserDto Update(Guid id, UserDto employee);

    UserDto Delete(Guid id);

    UserDto Add(UserDto employee);
}
