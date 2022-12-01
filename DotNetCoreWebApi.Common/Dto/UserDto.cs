namespace DotNetCoreWebApi.Common.Dto;
public class UserDto
{
    public Guid UserId { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string MiddleName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string WorkEmail { get; set; } = string.Empty;
    public string IDNumber { get; set; } = string.Empty;
}
