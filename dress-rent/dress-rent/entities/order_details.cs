namespace dress_rent.entities
{
        public class order_details
        {
            public int Id { get; set; }
            public int OrderId { get; set; }
            public int DressId { get; set; }

            public order_details(int id, int orderId, int dressId)
            {
                Id = id;
                OrderId = orderId;
                DressId = dressId;
            }

            public order_details()
            {

            }
        }
}
