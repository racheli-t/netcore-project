namespace dress_rent.entities
{

        public class customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }
            public string Phone { get; set; }
            public DateOnly BirthDate { get; set; }
            public DateOnly RegistratinDate { get; set; }

            public customer(int id, string name, string email, string address, string phone, DateOnly birthDate, DateOnly registratinDate)
            {
                Id = id;
                Name = name;
                Email = email;
                Address = address;
                Phone = phone;
                BirthDate = birthDate;
                RegistratinDate = registratinDate;
            }
            public customer()
            {

            }
        }
}
