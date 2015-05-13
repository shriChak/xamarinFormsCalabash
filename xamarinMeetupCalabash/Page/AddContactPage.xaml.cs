using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamarinMeetupCalabash
{
	public partial class AddContactPage : ContentPage
	{
		public Contact NewContact {
			get;
			set;
		}
		public AddContactPage ()
		{
			NewContact = new Contact ();
			InitializeComponent ();
		}
		private void AddNewContactClicked(object sender, EventArgs args)
		{
			
			if (!string.IsNullOrEmpty (Name.Text) && !string.IsNullOrEmpty (PhoneNo.Text) && !string.IsNullOrEmpty (Address.Text)) {
				NewContact.Name = Name.Text;
				NewContact.PhoneNo = Convert.ToInt64(PhoneNo.Text.ToString());
				NewContact.Address = Address.Text;
				MessagingCenter.Send<AddContactPage, Contact> (this, "NewContact", NewContact);
			} else
				DisplayAlert ("Error", "Enter all fields", "OK");
			Navigation.PopAsync ();
		}
	}
}

