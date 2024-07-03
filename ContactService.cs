using BlazorServerAppDemo.Components;
using BlazorServerAppDemo.Components.Models;
using BlazorServerAppDemo.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerAppDemo
{
    public class ContactService : IContactService
    {
        //[Inject]
        //DataContext DataContext { get; set; }

        private List<Contact> ContactList = new List<Contact>();

        public List<Contact> GetContacts()
        {
            return ContactList;
        }
        private readonly DataContext _context;

        public ContactService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Contact>> GetContactsAsync()
        {
            return await _context.Contacts.ToListAsync();
        }

        public async Task AddContactAsync(Contact contact)
        {
            _context.Contacts.Add(contact);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteContactAsync(Contact contact)
        {
            _context.Contacts.Remove(contact);
            await _context.SaveChangesAsync(true);
        }

        public async Task UpdateContactAsync(Contact contact)
        {
            _context.Entry(contact).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

    }
}
