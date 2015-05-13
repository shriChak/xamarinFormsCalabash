using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamarinMeetupCalabash
{
	public partial class ContactListPage : ContentPage
	{
		ContactViewModel viewModel;
		public ContactListPage ()
		{
			InitializeComponent ();
			viewModel = new ContactViewModel ();
			this.BindingContext = viewModel;
			var eg = viewModel.ContactList;

			MessagingCenter.Subscribe<ContactViewModel> (this, "NavToAdd", (sender) => {
				Navigation.PushAsync(new AddContactPage());
			});
		}
		private void BGRmvBtnClicked(object sender, EventArgs args)
		{
			MenuItem item = sender as MenuItem;
			if (item != null) {
				
				MessagingCenter.Send<ContactListPage, long> (this, "RemoveMessageRequest", (long)item.CommandParameter);
			}
		}
		private void ContactItemTapped(object sender, ItemTappedEventArgs args)
		{
		}

	}
}

