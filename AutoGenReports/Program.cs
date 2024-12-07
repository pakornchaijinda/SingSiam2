using AutoGenReports;
using FluentScheduler;

Console.WriteLine("Hello, World!");
JobManager.Initialize(new RunAutoJob());
Console.ReadLine();