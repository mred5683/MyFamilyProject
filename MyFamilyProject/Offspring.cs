namespace MyFamilyProject
{
    public class Offspring
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string FavoriteToy { get; set; }
        public string FavoriteSuperHero { get; set; }
        public string Chores { get; set; }

        public Offspring(string name, string age, string favoriteToy, string favoriteSuperHero, string chores)
        {
            Name = name;
            Age = age;
            FavoriteToy = favoriteToy;
            FavoriteSuperHero = favoriteSuperHero;
            Chores = chores;
        }
    }
}
