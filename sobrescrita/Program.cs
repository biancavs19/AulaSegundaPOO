
using System.Globalization;

Console.WriteLine("Hello, World!");

CultureInfo.CurrentCulture = new CultureInfo("en-USA");

Cartao cartaoBase = new Cartao();
cartaoBase.Debitar(100);

Console.WriteLine("-- Cartao de debito --");

Cartao cartaoDebito = new CartaoDebito();
cartaoDebito.Debitar(100);