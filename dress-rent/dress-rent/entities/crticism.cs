namespace dress_rent.entities
{
        public class criticism
        {
            public int Id { get; set; }
            public int CustomerId { get; set; }
            public int DressId { get; set; }
            public DateOnly CriticismDate { get; set; }

            public int Rating { get; set; }
            public string Content { get; set; }
            public bool Isrecomended { get; set; }

            public criticism(int id, int customerId, int dressId, DateOnly criticismDate, int rating, string content, bool isrecomended)
            {
                Id = id;
                CustomerId = customerId;
                DressId = dressId;
                CriticismDate = criticismDate;
                Rating = rating;
                Content = content;
                Isrecomended = isrecomended;
            }
            public criticism()
            {

            }




        }
    }
