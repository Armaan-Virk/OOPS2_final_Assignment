using Microsoft.Maui.Controls;

namespace GymManagementSystem
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnManageMembersClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MemberManagementPage());
        }

        private async void OnTrackSubscriptionsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SubscriptionTrackingPage());
        }

        private async void OnRecordAttendanceClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AttendanceTrackingPage());
        }

        private async void OnManageSchedulesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ScheduleManagementPage());
        }
    }
}
