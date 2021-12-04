using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Convert.ConvertToPDF("C:\\dotnet\\FirstProject\\File.csv", "C:\\dotnet\\FirstProjectFile.pdf");
            Convert.ConvertToXML("C:\\dotnet\\FirstProject\\File.csv", "C:\\dotnet\\FirstProjectFile.xml");
        }
    }
}
