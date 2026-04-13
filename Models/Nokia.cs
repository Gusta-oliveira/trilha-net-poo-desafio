namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero) : base(numero)
        {
            Modelo = "Nokia 3310";
            IMEI = "123456789";
            Memoria = 64;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Nokia...");
        }
    }
}