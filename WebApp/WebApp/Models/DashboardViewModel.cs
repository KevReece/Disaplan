namespace Disaplan.WebApp.Models
{
    public class DashboardViewModel
    {
        public DashboardViewModel(string userName)
        {
            UserName = userName;
        }

        public string UserName { get; private set; }
    }
}