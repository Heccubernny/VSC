namespace vsc.Application.Common.Interfaces.Authentication.Services
{
    public interface IDateTimeProvider
    {
        DateTime UtcNow { get; }
    }
}
