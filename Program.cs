using System.Globalization;
using System.ComponentModel;
using DesafioPOO.Models;
using DesafioPOO.Models;

Iphone iphone = new(numero = "1234", modelo = "" );
Nokia nokia= new(numero2 = "1234", modelo2 = "5678", imei2 = "5ujkk", memoria2 = 9);
Console.WriteLine(nokia.Numero);
nokia.InstalarAplicativo("whatsapp");
