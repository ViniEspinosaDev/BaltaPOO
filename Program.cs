using BaltaPOO.ContentContext;
using BaltaPOO.SubscriptionContext;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BaltaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "Orientacao-objetos"));
            articles.Add(new Article("Artigo sobre DI", "Injecao-dependencia"));
            articles.Add(new Article("Artigo sobre IoC", "Inversao-controle"));

            foreach (Article article in articles)
            {
                //Console.WriteLine(article.ToString());
            }

            var courses = new List<Course>();

            var course = new Course("Fundamentos OOP", "fundamentos-OOP");
            var courseCsharp = new Course("Fundamentos C#", "fundamentos-CSharp");
            var courseDotnet = new Course("Fundamentos .Net", "fundamentos-dotnet");

            courses.Add(course);
            courses.Add(courseCsharp);
            courses.Add(courseDotnet);

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista backend", "dotnet");
            var careerItem2 = new CareerItem(2, "aprenda aqui", "", "", null);
            var careerItem1 = new CareerItem(1, "comece aqui", "", "", null);
            var careerItem3 = new CareerItem(3, "anuncie aqui", "", "", courseDotnet);
            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem3);
            careerDotnet.Items.Add(careerItem1);
            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine($"Career: {career.Title}");
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    if (item.IsValid)
                        Console.WriteLine($"{item.Order} - {item.Title}");
                    else
                        Console.WriteLine($"Retorno: {item.Notifications.First().Message}");
                }
            }

            var student = new Student();
            student.CreateSubscription(new Subscription());
        }
    }
}
