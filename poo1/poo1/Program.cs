using DesafioPOO.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        Iphone iphone = new Iphone(numero: "123456789", imei: "123456789012345", modelo: "IPhone 15 pro max", memoria: 256);
        Console.WriteLine("\nIphone:");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");

        Nokia nokia = new Nokia(numero: "987654321", imei: "678901234567890", modelo: "Nokia 3310", memoria: 64);
        Console.WriteLine("\nNokia:");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Facebook");

    }
}
