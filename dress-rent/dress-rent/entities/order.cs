namespace dress_rent.entities
{

        public class order
        {
            public int Id { get; set; }
            public int CustomerId { get; set; }
            public DateOnly OrderDate { get; set; }
            public DateOnly RentDate { get; set; }
            public DateOnly ReturnDate { get; set; }
            public bool Status { get; set; }

            public order(int id, int customerId, DateOnly orderDate, DateOnly rentDate, DateOnly returnDate, bool status)
            {
                Id = id;
                CustomerId = customerId;
                OrderDate = orderDate;
                RentDate = rentDate;
                ReturnDate = returnDate;
                Status = status;
            }
            public order()
            {

            }
        }
}
