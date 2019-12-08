using System;

namespace CodeNation
{
    class Program
    {
        static void Main(string[] args)
        {
            var codeNationResponse = CodeNationApiResponses.GetValue();
            JsonFile.WriteValue(codeNationResponse);
            System.Console.WriteLine(codeNationResponse.numero_casa);
        }
    }
}
