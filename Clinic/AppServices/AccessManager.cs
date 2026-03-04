namespace Clinic.AppServices
{
    public static class AccessManager
    {
        public static string GetCurrentRole()
        {
            return ContextManager.user.Role ?? "Неавторизован";
        }

        public static bool IsAdmin()
        {
            return ContextManager.user.Role == "Администратор";
        }

        public static bool IsMedic()
        {
            return ContextManager.user.Role == "Врач";
        }
        public static bool IsGuest()
        {
            return ContextManager.user.Role == "Гость";
        }

        public static bool IsPatient()
        {
            return ContextManager.user.Role == "Пациент";
        }
    }
}
