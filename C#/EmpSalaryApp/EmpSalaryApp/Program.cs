using System;
using EmpSalaryApp.Model;
using System.IO;

namespace EmpSalaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee manager = new Manager(101, "Abcd", 25000);
            Employee developer = new Developer(101, "Dev", 20000);
            Employee analsyt = new Analyst(101, "Lee", 18000);

            String htmlContent = manager.GenerateCTCDetails();
            WriteToHTML(htmlContent, manager.GetName);
            WriteToHTML(developer.GenerateCTCDetails(), developer.GetName);
            WriteToHTML(analsyt.GenerateCTCDetails(),analsyt.GetName);
        }

        private static void WriteToHTML(string htmlContent, String name)
        {
            Element rootTag = new Element("Html", "");

            Element headTag = new Element("head", "");
            rootTag.addChildren(headTag);
            Element titleTag = new Element("title", "Salary Details");
            headTag.addChildren(titleTag);

            Element bodyTag = new Element("body", "");
            Element pTag = new Element("p", htmlContent);
            bodyTag.addChildren(pTag);
            rootTag.addChildren(bodyTag);

            String htmlString = rootTag.renderHtmlString();

            using (StreamWriter htmlFile = new StreamWriter(name + "Salary.html"))
            {
                htmlFile.WriteLine(htmlString);
            }


        }
    }
}
