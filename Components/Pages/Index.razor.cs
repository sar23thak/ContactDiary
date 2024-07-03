using BlazorServerAppDemo.Components.Models;
using BlazorServerAppDemo.Components.Pages.ContactComponents;
using Microsoft.AspNetCore.Components;

namespace BlazorServerAppDemo.Components.Pages
{
    public partial class Index
    {
        [Inject] IContactService contactService { get; set; }

        
        private ContactList contactList;
        private bool isContactDisplayed = true;

        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(500);
            
            //contacts = new List<Contact>
            //{
            //    new Contact
            //    {
            //        FirstName = "Test",
            //        LastName = "Test",
            //        Email = "ABC@GMAIL.COM"
            //    },
            //    new Contact
            //    {
            //        FirstName = "Test1",
            //        LastName = "Test1",
            //        Email = "ABC@GMAIL.COM"
            //    }
            //};
            base.OnInitializedAsync();
        }
        private void HideContact()
        {
            isContactDisplayed = !isContactDisplayed;
            if (isContactDisplayed)
            {
                contactList.ShowContacts();
            }
            else
            {
                contactList.HideContacts();
            }
        }
    }
}
