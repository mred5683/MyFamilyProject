namespace MyFamilyProject
{
    public class Husband
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Job { get; set; }
        public string Goal { get; set; }
        
        public Husband(string name, string age, string job, string goal)
        {
            Name = name;
            Age = age;
            Job = job;
            Goal = goal;
        }
    }
}
