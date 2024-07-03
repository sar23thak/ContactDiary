using BlazorServerAppDemo.Components.Models;

namespace BlazorServerAppDemo.Components
{
    public interface IContactService
    {
        Task <List<Contact>> GetContactsAsync();
        Task AddContactAsync(Contact contact);
        Task DeleteContactAsync(Contact contact);
        Task UpdateContactAsync(Contact contact);
    }
}
