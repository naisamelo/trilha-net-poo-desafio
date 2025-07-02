using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\t\t\t\t\t");

Console.WriteLine("Samartphone iPhone");
Smartphone iphone = new Iphone(numero: "789321", modelo: "X", imei: "22222222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");