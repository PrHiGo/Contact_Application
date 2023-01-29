using System.Net.NetworkInformation;

namespace Contact_Application.Utilities
{
    public class Toggle
    {
        public static bool isOpen;

        public static void OpenMenu()
        {
            isOpen = !isOpen;
        }

    }
}