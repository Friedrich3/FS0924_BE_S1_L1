

namespace FS0924_BE_S1_L1
{
    internal class Animale
    {
        public string Nome {  get; set; }
        public string Specie {  get; set; }  
        public string Razza {  get; set; }  
        public int Age {  get; set; }

        public string Dieta {  get; set; }



        public Animale(string nome , string specie,string razza, int age,string dieta)
        {
            Nome = nome;
            Specie = specie;
            Razza = razza;
            Age = age;
            Dieta = dieta;
        }


        public void Show()
        {
            Console.WriteLine("L'Animale in cura e':" + Nome + " ,appartenente alla razza: " +Specie +" "+ Razza + ", di anni " + Age + "; note di riguardo: mangia solo " + Dieta);
        }




    }
}
