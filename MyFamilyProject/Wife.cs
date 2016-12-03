namespace MyFamilyProject
{
    public class Wife
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Job { get; set; } 
        public string Goal { get; set; }       

        public Wife(string name, string age, string job, string goal)
        {
            Name = name;
            Age = age;
            Job = job;
            Goal = goal;
        }
    }
}
