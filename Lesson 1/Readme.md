# Общие понятия о разработке, .Net и ASP


## Содержание

1. [Git](#Git)
2. [.Net](#.Net)
3. [C#](#C#)
4. [ASP](#ASP)
5. [NuGet](#NuGet)


## Git

[Git](https://git-scm.com) - система контроля версий.


## .Net

[.Net](https://dotnet.microsoft.com) - программная платформа для разработки (SDK) и запуска (Runtime) приложений.

У Microsoft часто возникают проблемы с названиями, из-за чего пользователи путаются. Есть несколько семейств .Net:
- .Net Framework: появился раньше остальных, работал только под Windows
- .Net Core: появился после .Net Framework и развивался параллельно с ним, кросс-платформа
- .Net: является заменой .Net Framework и .Net Core, базируется на .Net Core.

Также существуют такие понятия, как .Net Mono Runtime (форк .Net Framework с целью обеспечить кросс-платформенность) и
.Net Standard - спецификация, выполняющая роль синхронизации .Net Framework и .Net Core (код, написанный в формате .Net
Standard работает и на .Net Framework и на .Net Core).

В данном курсе мы будем использовать [.Net 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0).


## C#

[C#](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp) - один из языков для разработки на .Net платформе.
Он и будет использоваться в данном курсе.

Поскольку, в данном курсе мы будем использовать .Net 6.0, мы также будем использовать C# 10 (поддерживается .Net 6.0+).


## ASP

[ASP](https://dotnet.microsoft.com/apps/aspnet) - фреймворк для разработки веб-приложений на .Net.

С названиями у ASP всё ещё хуже, чем у .Net, так что я даже не буду пытаться это объяснить. Пока будет достаточно знать,
что его также могут называть:
- ASP .Net
- ASP .Net Core
- ASP .Net Core MVC
- новый ASP .Net.


## NuGet

[NuGet](https://www.nuget.org) - менеджер пакетов/зависимостей для .Net. С помощью него мы будем устанавливать все
необходимые библиотеки.