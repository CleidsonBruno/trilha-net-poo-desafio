using DesafioPOO.Models;


class Program
{
    static void Main(string[] args)
    {
        Smartphone nokia = new Nokia("123456789", "Nokia 3310", "1111111111", 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        Smartphone iphone = new Iphone("987654321", "iPhone 13", "2222222222", 128);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}