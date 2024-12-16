using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace GymManagementSystem
{
    public partial class AttendanceTrackingPage : ContentPage
    {
        private ObservableCollection<string> _attendanceRecords = new ObservableCollection<string>();

        public AttendanceTrackingPage()
        {
            InitializeComponent();
            AttendanceList.ItemsSource = _attendanceRecords;
        }

        private void OnMarkAttendanceClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(MemberIDInput.Text))
            {
                string record = $"{MemberIDInput.Text}: {DateTime.Now}";
                _attendanceRecords.Add(record);
                MemberIDInput.Text = string.Empty;
            }
            else
            {
                DisplayAlert("Error", "Please enter Member ID.", "OK");
            }
        }
    }
}
