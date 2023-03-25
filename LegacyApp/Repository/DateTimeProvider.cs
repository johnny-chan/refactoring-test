using System;

namespace LegacyApp.Repository
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime DateTimeNow => DateTime.UtcNow;
    }
}