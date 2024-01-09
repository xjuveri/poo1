namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string IMEI { get; set; }
        protected string Modelo { get; set; }
        protected int Memoria { get; set; }

        public Smartphone(string numero, string imei, string modelo, int memoria)
        {
            Numero = numero;
            IMEI = imei;
            Modelo = modelo;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}