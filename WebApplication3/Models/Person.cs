namespace WebApplication3.Models
{
    public class Person
    {
        private static int count = 0;

        public Person()
        {
            count++;
            this.Id = count;
        }

        public int Id { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}
