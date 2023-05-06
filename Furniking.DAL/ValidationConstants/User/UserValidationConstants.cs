namespace Furniking.DAL.ValidationConstants.User
{
    public static class UserValidationConstants
    {
        public static int MaxFailedAccessAttempts { get; } = 5;
        public static TimeSpan DefaultLockoutTimeSpan { get; } = new TimeSpan(0, 5, 0);

        public const int PasswordRequiredLength = 6;
    }
}
