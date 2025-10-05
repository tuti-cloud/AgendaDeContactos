using AgendaDeContactos.Entities;
using AgendaDeContactos.Repositories.Interfaces;

namespace AgendaDeContactos.Repositories.Implementations
{
    public class ContactRepository : IContactRepository
    {
        public static List<Contact> Contacts = new List<Contact>
        {
            new Contact { Id = 1, FirstName = "Sofía", LastName = "Mendoza", Address = "Av. Siempre Viva 123", Number = "341-1234567", Email = "sofia.mendoza@example.com", Company = "Tech SA", Description = "Proveedor de servicios IT", UserId = 1, IsFavorite = true },
            new Contact { Id = 2, FirstName = "Diego", LastName = "Alvarez", Address = "Calle San Martín 456", Number = "341-7654321", Email = "diego.alvarez@example.com", Company = "Marketing Group", Description = "Contacto de negocio", UserId = 2, IsFavorite = false },
            new Contact { Id = 3, FirstName = "Valentina", LastName = "Castro", Address = "Av. Pellegrini 789", Number = "341-5551234", Email = "valentina.castro@example.com", Company = "Ventas SRL", Description = "Cliente frecuente", UserId = 3, IsFavorite = true },
            new Contact { Id = 4, FirstName = "Martín", LastName = "Díaz", Address = "Boulevard Oroño 1000", Number = "341-8889999", Email = "martin.diaz@example.com", Company = "Consultores SA", Description = "Consultoría en negocios", UserId = 4, IsFavorite = false },
            new Contact { Id = 5, FirstName = "Camila", LastName = "Herrera", Address = "Belgrano 222", Number = "341-4447777", Email = "camila.herrera@example.com", Company = "Estudio Contable", Description = "Asesora contable", UserId = 5, IsFavorite = true },
            new Contact { Id = 6, FirstName = "Gonzalo", LastName = "Ruiz", Address = "Italia 321", Number = "341-6665555", Email = "gonzalo.ruiz@example.com", Company = "Startup XYZ", Description = "Emprendedor tecnológico", UserId = 6, IsFavorite = false },
            new Contact { Id = 7, FirstName = "Julieta", LastName = "Santos", Address = "Santa Fe 654", Number = "341-2221111", Email = "julieta.santos@example.com", Company = "Diseño SRL", Description = "Diseñadora gráfica", UserId = 7, IsFavorite = true },
            new Contact { Id = 8, FirstName = "Federico", LastName = "Morales", Address = "Mitre 987", Number = "341-9990000", Email = "federico.morales@example.com", Company = "Agencia Publicitaria", Description = "Ejecutivo de cuentas", UserId = 8, IsFavorite = false },
            new Contact { Id = 9, FirstName = "Regina", LastName = "Schiavo", Address = "Mitre 987", Number = "341-9990000", Email = "federico.morales@example.com", Company = "Agencia Publicitaria", Description = "Ejecutivo de cuentas", UserId = 8, IsFavorite = false }
        };

        public int Create(Contact newContact)
        {
            var nextId = Contacts.Count == 0 ? 1 : Contacts.Max(c => c.Id) + 1;
            newContact.Id = nextId;           
            Contacts.Add(newContact);
            return nextId;
        }



        public void Delete(int id)
        {
            var contact = Contacts.FirstOrDefault(c => c.Id == id);
            if (contact != null)
            {
                Contacts.Remove(contact);
            }
        }

        public IEnumerable<Contact> GetAllByUser(int userId)
        {
             return Contacts.Where(c => c.UserId == userId).ToList();
        }

        public Contact? GetByContactId(int contactId)
        {
            return Contacts.SingleOrDefault(c => c.Id == contactId);
        }


        public Contact? GetOneByUser(int userid, int Id)
        {
            return Contacts.FirstOrDefault(c => c.UserId == userid && c.Id == Id);
        }

        public void Update(Contact updatedContact, int Id)
        {
            Contact? contact = Contacts.SingleOrDefault(contact => contact.Id == Id);
            if (contact is not null)
            {
                contact.Email = updatedContact.Email;
                contact.Image = updatedContact.Image;
                contact.Number = updatedContact.Number;
                contact.Company = updatedContact.Company;
                contact.Address = updatedContact.Address;
                contact.LastName = updatedContact.LastName;
                contact.FirstName = updatedContact.FirstName;
                contact.Description = updatedContact.Description;
                
            }
        }
    }
}
