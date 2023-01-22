using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia...");
Nokia nokia = new Nokia(numero: "123456", modelo: "Tijolão", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smarphone Iphone...");
Iphone iphone = new Iphone(numero: "654321", modelo: "14 Plus", imei: "222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");