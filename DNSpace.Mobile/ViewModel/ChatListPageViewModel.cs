using DNSpace.Mobile.Constants.List;
using DNSpace.Mobile.DataViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNSpace.Mobile.ViewModel
{
  public class ChatListPageViewModel : BindableObject
  {
    public ObservableCollection<ContactViewModel> ContactList { get; set; } = new ObservableCollection<ContactViewModel>();
    public ChatListPageViewModel()
    {
      GetAllUserContactList();
    }


    public void GetAllUserContactList()
    {
      var contacts = ListOfContact.GetListOfContacts();
      var countContacts = contacts.Count();
      foreach (var contact in contacts)
      {
        ContactList.Add(contact);
      }

    }
  }
}
