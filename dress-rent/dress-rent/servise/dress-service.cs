namespace dress_rent.servise
{

    using dress_rent.entities;


        public class dress_service
        {
            public  List<dress> dresslist { get; set; }

            dress d = new dress();

            public dress_service()
            {
                dresslist = new List<dress>() {
                new dress(1,"nice",18,"blue","zamsh",1000,2),
              new dress(2,"cool",20,"red","wood",800,1) ,

            };
            }
            public List<dress> GetList() { return dresslist; }
            public dress GetById(int id) { return dresslist.Find(x => x.Id == id); }
            public bool AddDress(dress dress) { dresslist.Add(dress); return true; }
            public bool Update(int id, dress s)
            {

                int index = dresslist.FindIndex(x => x.Id == id);
                if (index < 0)
                    return false;
                dresslist.Insert(index, s);
                return true;
            }
            public bool Remove(int id)
            {
                int index = dresslist.FindIndex(x => x.Id == id);
                if (index == -1) return false;
                dresslist.RemoveAt(index);
                return true;
            }
        }
    }


