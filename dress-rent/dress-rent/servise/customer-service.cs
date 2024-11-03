namespace dress_rent.servise
{
    using dress_rent.entities;


        public class customer_service
        {
            public  List<customer> customerlist { get; set; }



            public customer_service()
            {
                customerlist = new List<customer>() {
                new customer(1,"yosi","r0504180710@gmail.com","even-gvirol","0504180710",new DateOnly(2010,10,5),new DateOnly(2023,10,5)),
               new customer(1,"yosi","r0504180710@gmail.com","even-gvirol","0504180710",new DateOnly(2010,10,5),new DateOnly(2023,10,5)),
            };
            }
            public List<customer> GetList() { return customerlist; }
            public customer GetById(int id) { return customerlist.Find(x => x.Id == id); }
            public bool AddCustomer(customer customer) { customerlist.Add(customer); return true; }
            public bool Update(int id, customer customer)
            {

                int index = customerlist.FindIndex(x => x.Id == id);
                if (index < 0)
                    return false;
                customerlist.Insert(index, customer);
                return true;
            }
            public bool Remove(int id)
            {
                int index = customerlist.FindIndex(x => x.Id == id);
                if (index == -1) return false;
                customerlist.RemoveAt(index);
                return true;
            }
        }
    }



