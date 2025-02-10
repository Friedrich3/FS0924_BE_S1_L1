namespace FS0924_BE_S1_L1
{
    internal class Dipendente
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public int BadgeNumber { get; set; }

        public Dipendente(string firstname, string lastname, string role, int badge)
        {
            FirstName = firstname;
            LastName = lastname;
            Role = role;
            BadgeNumber = badge;
        }


        public void Show()
        {
            Console.WriteLine($"Il badge:{BadgeNumber} e' entrato alle ore 09.15, {FirstName} {LastName} con il ruolo di: {Role}");
        }


    }
}
