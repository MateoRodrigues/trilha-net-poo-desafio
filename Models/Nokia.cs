using DesafioPOO.Models;
namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero2,string modelo2,string imei2, int memoria2) : base(numero,modelo,imei,memoria)
         {

         }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp}, no Nokia");
        }
    }
}