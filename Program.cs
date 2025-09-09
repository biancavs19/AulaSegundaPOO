﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Televisao tv = new Televisao(55f);

Console.WriteLine($"A tv tem o tamanho {tv.Tamanho}");

tv.AumentarVolume();
Console.WriteLine($"Volume {tv.Volume}");

tv.AumentarVolume();
Console.WriteLine($"Volume {tv.Volume}");

tv.AumentarVolume();
Console.WriteLine($"Volume {tv.Volume}");

tv.DiminuirVolume();
Console.WriteLine($"Volume {tv.Volume}");

tv.DiminuirVolume();
Console.WriteLine($"Volume {tv.Volume}");

tv.DiminuirVolume();
Console.WriteLine($"Volume {tv.Volume}");


tv.AumentarCanal();
Console.WriteLine($"Canal {tv.Canal}");

tv.AumentarCanal();
Console.WriteLine($"Canal {tv.Canal}");


tv.DiminuirCanal();
Console.WriteLine($"Canal {tv.Canal}");

tv.DiminuirCanal();
Console.WriteLine($"Canal {tv.Canal}");


tv.CanalEspecifico(520);
Console.WriteLine($"Canal {tv.Canal}");