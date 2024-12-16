using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace GymManagementSystem
{
    public partial class ScheduleManagementPage : ContentPage
    {
        private ObservableCollection<string> _schedules = new ObservableCollection<string>();

        public ScheduleManagementPage()
        {
            InitializeComponent();
            ScheduleList.ItemsSource = _schedules;
        }

        private void OnAddScheduleClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ScheduleInput.Text))
            {
                _schedules.Add(ScheduleInput.Text);
                ScheduleInput.Text = string.Empty;
            }
            else
            {
                DisplayAlert("Error", "Please enter schedule details.", "OK");
            }
        }
    }
}
