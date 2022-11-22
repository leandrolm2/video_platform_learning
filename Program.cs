// See https://aka.ms/new-console-template for more information
using OOP_IN_C_SHARP.ContentContext;

var articles = new List<Article>();

articles.Add(new Article("Article about POO", "oriented-object"));
articles.Add(new Article("Article about c#", "oriented-object"));
articles.Add(new Article("Article about .net", "oriented-object"));

foreach (var article in articles)
{
    Console.WriteLine(article.Id);
    Console.WriteLine(article.Title);
    Console.WriteLine(article.Url);
}

var courses = new List<Course>();
var coursePOO = new Course("POO fundamentals", "POO-FUNDAMENTALS");
var courseCsharp = new Course("C# fundamentals", "fundamentals -csharp");
var courseAspNet = new Course("fundamentals ASP.NET", "fundamentals-aspnet");

courses.Add(coursePOO);
courses.Add(courseCsharp);
courses.Add(courseAspNet);


var careers = new List<Career>();
var careerDotNet = new Career(".net specialist", "dotnet-specialist");
var carrerItem = new CareerItem(1, "starts here", "", courseCsharp);
var carrerItem2 = new CareerItem(2, "learn POO", "", null);
var carrerItem3 = new CareerItem(3, "learn .NET", "", courseAspNet);

careerDotNet.Items.Add(carrerItem2);
careerDotNet.Items.Add(carrerItem);
careerDotNet.Items.Add(carrerItem3);
careers.Add(careerDotNet);

foreach(var career in careers)
{
    Console.WriteLine(career.Title);
    foreach (var item in career.Items.OrderBy(x => x.Order))
    {
        Console.WriteLine($"{item.Order} - {item.Title}");
        Console.WriteLine(item.Course?.Title);
        Console.WriteLine(item.Course?.Level);

        foreach (var notification in item.Notifications)
        {
            Console.WriteLine($"{notification.Property} - {notification.Message}");
        }
    }
}