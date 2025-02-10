
namespace FS0924_BE_S1_L1
{
    internal class Atleta
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        private int age;
        public int Age { get { return age; } set { age = value; } }

        public string Sport { get; set; }



        public Atleta(string firstname, string lastname, int age, string sport)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Age = age;
            this.Sport = sport;
        }


        public void Show()
        {
            Console.WriteLine("L'atleta :"+FirstName +" "+LastName +" di anni " + Age +", pratica lo sport: " + Sport );
        }
    }
}
