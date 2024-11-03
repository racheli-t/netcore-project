namespace dress_rent.servise
{
    using dress_rent.entities;
        public class criticism_service
        {
            public  List<criticism> criticismlist { get; set; }
            public criticism_service()
            {
                criticismlist = new List<criticism>() {
                new criticism(1,2,2,new DateOnly(15,06,2024),10,"good",true),
                  new criticism(1,2,2,new DateOnly(15,06,2024),10,"good",true)
            };
            }
            public List<criticism> GetList() { return criticismlist; }
            public criticism GetById(int id) { return criticismlist.Find(x => x.Id == id); }
            public bool Addcriticism(criticism criticism) { criticismlist.Add(criticism); return true; }
            public bool Update(int id, criticism criticism)
            {

                int index = criticismlist.FindIndex(x => x.Id == id);
                if (index < 0)
                    return false;
                criticismlist.Insert(index, criticism);
                return true;
            }
            public bool Remove(int id)
            {
                int index = criticismlist.FindIndex(x => x.Id == id);
                if (index == -1) return false;
                criticismlist.RemoveAt(index);
                return true;
            }
        }

}
