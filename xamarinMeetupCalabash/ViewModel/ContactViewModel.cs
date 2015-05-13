using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace xamarinMeetupCalabash
{
	public class ContactViewModel
		:BaseViewModel
	{
		private ObservableCollection<Contact> _contactList;
		public ObservableCollection<Contact> ContactList {
			get{
				return _contactList;
			}
			set{
				_contactList = value;
				OnPropertyChanged ("ContactList");
			}
		}

		public ICommand AddNewContact { private set; get; }

		public ContactViewModel ()
		{
			ContactList = new ObservableCollection<Contact> ();
			Contact c = new Contact ();
			c.Address="62 Goulburn Street";
			c.PhoneNo = 0421151152;
			c.Name="Shri";
			ContactList.Add (c);
			AddNewContact = new Command (() => {
				MessagingCenter.Send<ContactViewModel>(this, "NavToAdd");
			});
			MessagingCenter.Subscribe<AddContactPage, Contact>
			(this, "NewContact", (sender, args) => {
				ContactList.Add(args);
				OnPropertyChanged ("ContactList");
			});

			MessagingCenter.Subscribe<ContactListPage, long> (this, "RemoveMessageRequest", (sender, requestID) => {
				for (int i = 0; i < ContactList.Count; i++) {
					if (ContactList [i] != null && ContactList [i].PhoneNo == requestID) {
						ContactList.RemoveAt (i--);
						break;
					}
				}
				OnPropertyChanged ("ContactList");
			});
				
		}

	}
}

