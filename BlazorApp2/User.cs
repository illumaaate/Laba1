namespace BlazorApp2
{
    public class User
    {
        public string SName { get; set; }
        public string Name { get; set; }
        public string Otch { get; set; }
        public int? Age { get; set; }
        public string Resume
        {
            get
            {
                return SName + " " + Name + " " + Otch + ". Полных лет: " + Age;
            }
        }
        public User(string sname, string name, string otch, int? age)
        {
            SName = sname;
            Name = name;
            Otch = otch;
            Age = age;
        }
    }
}
