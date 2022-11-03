using SistemaParaCelular.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "777111", modelo: "N01", imei: "121212", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "777222", modelo: "I12 PRO", imei: "121314", memoria: 138);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");