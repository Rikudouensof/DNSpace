using DNSpace.Mobile.DataViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNSpace.Mobile.Constants.List
{
  public class ListOfContact
  {

    public static IEnumerable<ContactViewModel> GetListOfContacts()
    {
      List<ContactViewModel> list = new List<ContactViewModel>();
      Random random = new Random();


      for (int i = 0; i < 5; i++)
      {
        list.Add(new ContactViewModel()
        {
          FullName = "Cortana Mastercheif",
          LastMessage = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
          ImageName = "https://engineer.rikudouensof.com/ImageUploads/a15ea62f-96fc-487e-9a40-320bec41c960_IMG_0229.jpg",
          LastMessageTime = DateTime.UtcNow.ToString("HH:mm:ss")
        });
      }




      return list;

    }
  }
}
