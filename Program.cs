// See https://aka.ms/new-console-template for more information
using CMS.Core;
using CMS.DataEngine;
using Microsoft.Extensions.Configuration;

Service.Use<IConfiguration>(new ConfigurationBuilder().AddJsonFile("appsettings.json").Build());

CMSApplication.Init();

Console.WriteLine("Xperience by Kentico successfully initialized!");