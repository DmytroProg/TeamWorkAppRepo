using TeamApp;
Task5Service.Init();

ProductService.ProductMainEntryAsync(@"D:\Desk\IT-S\NetworkProgramming\Lesson_6\TeamWork\TeamWorkAppRepo\TeamApp\context.stor").GetAwaiter().GetResult();
Console.WriteLine("Hello, World!");
Console.WriteLine("Test");