using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace GymManagementSystem
{
    public partial class SubscriptionTrackingPage : ContentPage
    {
        private ObservableCollection<string> _subscriptions = new ObservableCollection<string>();

        public SubscriptionTrackingPage()
        {
            InitializeComponent();
            SubscriptionList.ItemsSource = _subscriptions;
        }

        private void OnUpdateSubscriptionClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(MemberIDInput.Text) && !string.IsNullOrWhiteSpace(ExpiryDateInput.Text))
            {
                string newSubscription = $"{MemberIDInput.Text}: Expires on {ExpiryDateInput.Text}";
                _subscriptions.Add(newSubscription);
                MemberIDInput.Text = string.Empty;
                ExpiryDateInput.Text = string.Empty;
            }
            else
            {
                DisplayAlert("Error", "Please enter both Member ID and Expiry Date.", "OK");
            }
        }
    }
}
