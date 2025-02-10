
namespace FS0924_BE_S1_L1
{
    internal class Veicolo
    {
        public string Marca { get; set; }
        public string Modello { get; set; }
        public string Targa { get; set; }
        public int AnnoImmatric { get; set; }
        public string Carburante { get; set; }
        public int Prezzo {  get; set; }


        public Veicolo(string marca,string modello, string targa,int annoImmatric, string carburante , int prezzo)
        {
            Marca = marca;
            Modello = modello;
            Targa = targa;
            AnnoImmatric = annoImmatric;
            Carburante = carburante;
            Prezzo = prezzo;
        }



        public void Show()
        {
            Console.WriteLine($"Il Veicolo: {Marca} {Modello} con immatricolazione nell'anno: {AnnoImmatric} e tipo di combustibile: {Carburante} e' stato venduto alla cifra di: ${Prezzo}");
        }
    }
}
