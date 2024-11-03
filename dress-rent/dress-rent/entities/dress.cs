namespace dress_rent.entities
{
        public class dress
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Size { get; set; }
            public string Color { get; set; }
            public string Material { get; set; }
            public double Price { get; set; }
            public int NumberOfTimesBorrowed { get; set; }

            public dress(int id, string name, int size, string color, string material, double price, int numberOfTimesBorrowed)
            {
                Id = id;
                Name = name;
                Size = size;
                Color = color;
                Material = material;
                Price = price;
                NumberOfTimesBorrowed = numberOfTimesBorrowed;
            }

            public dress()
            {

            }
            public override string ToString()
            {
                return $"Id:{Id},Name:{Name},Color:{Color},Size:{Size}";
            }
        }
}
