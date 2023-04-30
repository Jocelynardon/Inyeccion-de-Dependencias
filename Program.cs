// See https://aka.ms/new-console-template for more information

using Laboratorio_Inyección_Dependencias;
using Laboratorio_Inyección_Dependencias.Clases;
using Laboratorio_Inyección_Dependencias.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddScoped<IScoped, Espada>();
        services.AddScoped<IScoped, Trifuerza>();
        services.AddScoped<IScoped, Arco>();
        services.AddTransient<ITransient, Ganondorf>();
        services.AddTransient<ITransient, Zelda>();
        services.AddTransient<ITransient, Link>();
        services.AddSingleton<ISingleton, BatallaFinal>();
    })
    .Build();

InIdioma idioma = new Español();
idioma.dialogo();