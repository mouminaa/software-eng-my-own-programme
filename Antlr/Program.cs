// See https://aka.ms/new-console-template for more information

using Antlr.Content;
using Antlr4.Runtime;
using Newtonsoft.Json;


namespace Antlr;
class Program
{
    static void Main(string[] args)
    {
        var inputs = new string[] {
            "book a hotel room for Mumina Mussa and 3 guests on 23-SEP-2013 00:12",
            "book a hotel room  for Santosh Singh and 5 guests on 23-SEP-2013 00:12",
            "book a hotel room for Jonh Doe and 12 guests on 24-JUN-2013 00:12",
            "book a hotel room for Bill Chis and 11 guests on 26-JUN-2013 00:12",
            "book a hotel room for Mussa Abdarazak and 1 guests on 28-JUN-2013 00:12"
        };

        foreach (var input in inputs)
        {
            Console.WriteLine($"Processing input: {input}");

            var charStream = new AntlrInputStream(input);
            var lexer = new BookingLexer(charStream);
            var tokens = new CommonTokenStream(lexer);
            var parser = new BookingParser(tokens);

            var t = parser.booking().b;
            Console.WriteLine(JsonConvert.SerializeObject(t));
        }
    }
}

