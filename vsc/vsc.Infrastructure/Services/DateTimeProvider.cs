using vsc.Application.Common.Interfaces.Authentication.Services;

namespace vsc.Infrastructure.Services
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow
        {
            get { return DateTime.UtcNow; }
        }
    }
}
