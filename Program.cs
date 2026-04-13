using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
var nokia = new Nokia("123456789");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

var iphone = new Iphone("987654321");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");