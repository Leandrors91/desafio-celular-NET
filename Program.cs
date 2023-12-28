using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia("11-99896-8016","c12","111111-11-111111-1",64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("whatsaap");

Smartphone iphone = new Iphone("11-99896-8016","c12","111111-11-111111-1",64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("whatsaap");