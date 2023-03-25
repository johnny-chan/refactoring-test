using System;

namespace LegacyApp.Repository
{
    public interface IDateTimeProvider
    {
        public DateTime DateTimeNow { get; }
    }
}