namespace dress_rent.servise
{
    using dress_rent.entities;

    
        public class order_detail_service
        {

            public List<order_details> order_detailslist { get; set; }



            public order_detail_service()
            {
                order_detailslist = new List<order_details>() {
                new order_details(1,2,1),
               new order_details(2,3,2),
            };
            }
            public List<order_details> GetList() { return order_detailslist; }
            public order_details GetById(int id) { return order_detailslist.Find(x => x.Id == id); }
            public bool AddOrder_Detail(order_details order_detail) { order_detailslist.Add(order_detail); return true; }
            public bool Update(int id, order_details order_detail)
            {

                int index = order_detailslist.FindIndex(x => x.Id == id);
                if (index < 0)
                    return false;
                order_detailslist.Insert(index, order_detail);
                return true;
            }
            public bool Remove(int id)
            {
                int index = order_detailslist.FindIndex(x => x.Id == id);
                if (index == -1) return false;
                order_detailslist.RemoveAt(index);
                return true;
            }
        }

    }


