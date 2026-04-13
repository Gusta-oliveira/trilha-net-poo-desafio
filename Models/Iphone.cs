namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero) : base(numero)
        {
            Modelo = "Iphone 15";
            IMEI = "987654321";
            Memoria = 128;
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no iPhone...");
        }
    }
}