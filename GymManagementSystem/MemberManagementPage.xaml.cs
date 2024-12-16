using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace GymManagementSystem
{
    public partial class MemberManagementPage : ContentPage
    {
        private ObservableCollection<string> _members = new ObservableCollection<string>();

        public MemberManagementPage()
        {
            InitializeComponent();
            MemberList.ItemsSource = _members;
        }

        private void OnAddMemberClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(MemberNameInput.Text) && !string.IsNullOrWhiteSpace(MemberIDInput.Text))
            {
                string newMember = $"{MemberIDInput.Text}: {MemberNameInput.Text}";
                _members.Add(newMember);
                MemberNameInput.Text = string.Empty;
                MemberIDInput.Text = string.Empty;
            }
            else
            {
                DisplayAlert("Error", "Please enter both Member Name and Member ID.", "OK");
            }
        }
    }
}
