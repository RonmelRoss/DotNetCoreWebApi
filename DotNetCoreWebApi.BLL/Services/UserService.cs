using AutoMapper;
using DotNetCoreWebApi.BLL.Interface;
using DotNetCoreWebApi.Common.Dto;
using DotNetCoreWebApi.DAL.Contracts;
using DotNetCoreWebApi.DAL.Data.Models;

namespace NetCore.Modules.BLL.Services;
public class EmployeeService : IUserService
{
    private readonly IRepository _repository;
    private readonly IMapper _mapper;

    public EmployeeService(IRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public UserDto Add(UserDto employeeDto)
    {
        var user = _mapper.Map<UserDto, User>(employeeDto);
        _repository.Insert<User>(user);
        _repository.Save();
        employeeDto.UserId = user.Id;
        return employeeDto;
    }

    public UserDto Delete(Guid id)
    {
        var employee = _repository.GetById<User>(id);

        if (employee == null)
            throw new ArgumentException("Employee does not exist");

        _repository.Delete<User>(employee);
        _repository.Save();
        return _mapper.Map<UserDto>(employee);
    }

    public IEnumerable<UserDto> GetAll()
    {
        var employees = _repository.GetAll<User>().ToList();
        return _mapper.Map<IEnumerable<UserDto>>(employees);
    }

    public UserDto GetById(Guid id)
    {
        var employee = _repository.GetById<User>(id);
        var employeeDto = _mapper.Map<UserDto>(employee);
        return employeeDto;
    }

    public UserDto Update(Guid id, UserDto user)
    {
        var userEntity = _repository.GetById<User>(id);

        if (userEntity == null)
            throw new ArgumentException("Employee does not exist");


        _mapper.Map<UserDto, User>(user, userEntity);
        userEntity.Id = id;

        _repository.Update<User>(userEntity);
        _repository.Save();
        return user;

    }
}
