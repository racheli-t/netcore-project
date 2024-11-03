namespace dress_rent.servise
{
    using dress_rent.entities;

        public class order_service
        {

            public List<order> orderlist { get; set; }


            public order_service()
            {
                orderlist = new List<order>() {
                new order(1,2,new DateOnly(2021,12,12),new DateOnly(2021,30,12),new DateOnly(2022,12,01),true) ,
                new order(2,3,new DateOnly(2023,12,12),new DateOnly(2023,30,12),new DateOnly(2024,12,01),false)
            };
            }
            public List<order> GetList() { return orderlist; }
            public order GetById(int id) { return orderlist.Find(x => x.Id == id); }
            public bool AddOreder(order order) { orderlist.Add(order); return true; }
            public bool Update(int id, order order)
            {

                int index = orderlist.FindIndex(x => x.Id == id);
                if (index < 0)
                    return false;
                orderlist.Insert(index, order);
                return true;
            }
            public bool Remove(int id)
            {
                int index = orderlist.FindIndex(x => x.Id == id);
                if (index == -1) return false;
                orderlist.RemoveAt(index);
                return true;
            }
        }

    }
