namespace BlazorApp1.Models
{
    public class DepatService
    {
        private List<Depat> Depats;
        public DepatService()
        {

            Depats = new List<Depat>
            {
            new Depat { Id = 1, Name = "Computer Science" },
            new Depat { Id = 2, Name = "Information Systems" },
            new Depat { Id = 3, Name = "Software Engineering" }
            };
        }

        public List<Depat> getAll()
        {
            return Depats;
        }
        public Depat? getById(int Id)
        {
            return Depats.FirstOrDefault(x => x.Id == Id);
        }
    }
}
