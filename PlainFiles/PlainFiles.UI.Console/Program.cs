using PlainFiles.Core;

//CLASS MANUALCSVHELPER USAGE EXAMPLE
var people = new List<string[]>
{
    new[] { "FirstName", "LastName", "Age" },
    new[] { "John", "Doe", "30" },
    new[] { "Jane", "Smith", "25" },
    new[] { "Sam", "Brown", "40" }
};

var manualCsv = new ManualCsvHelper();
manualCsv.WriteCsv("people.csv", people);

var loaded = manualCsv.ReadCsv("people.csv");
foreach (var person in loaded)
{
    Console.WriteLine(string.Join("|", person));
}

// CLASS LOGWRITER USAGE EXAMPLE
//var textFile = new SimpleTextFile(".\\data.txt");
//var lines = textFile.ReadAllLines().ToList();
//var opt = string.Empty;

//using var logger = new LogWriter(".\\app.log");
//logger.WriteLog("INFO", "Application started.");
//do
//{
//    opt = Menu();
//    switch (opt)
//    {
//        case "1":
//            Console.WriteLine("File content:");
//            logger.WriteLog("INFO", "User viewed file content.");
//            foreach (var line in lines)
//            {
//                Console.WriteLine(line);
//            }
//            break;
//        case "2":
//            Console.Write("Enter a new line: ");
//            var newLine = Console.ReadLine();
//            if (!string.IsNullOrEmpty(newLine))
//            {
//                lines.Add(newLine);
//                Console.WriteLine("Line added.");
//                logger.WriteLog("INFO", $"User added: {newLine}");
//            }
//            else
//            {
//                Console.WriteLine("No line entered.");
//                logger.WriteLog("WARNING", "User attempted to add an empty line.");
//            }
//            break;
//        case "3":
//            textFile.WriteAllLines(lines.ToArray());
//            Console.WriteLine("File saved.");
//            logger.WriteLog("INFO", "User saved the file.");
//            break;
//        case "0":
//            Console.WriteLine(":::::::::::::::::::::::::::::::");
//            Console.WriteLine(":::::::::: GAME OVER ::::::::::");
//            Console.WriteLine(": THANKS FOR USING OUR PROGRAM:");
//            Console.WriteLine(":::::::: HAVE A GOD DAY :::::::");
//            Console.WriteLine(":::::::::::::::::::::::::::::::");
//            logger.WriteLog("INFO", "Application exited by user.");
//            break;
//        default:
//            Console.WriteLine("Invalid option. Please try again.");
//            logger.WriteLog("ERROR", $"User selected invalid option: {opt}");
//            break;
//    }
//}
//while (opt != "0");
//textFile.WriteAllLines(lines.ToArray());
//Console.WriteLine("File saved.");
//logger.WriteLog("INFO", "Application ended and file saved.");

//string Menu()
//{
//    Console.WriteLine(":::::::::: MENÚ ::::::::::");
//    Console.WriteLine();
//    Console.WriteLine("1. Show file content.");
//    Console.WriteLine("2. Add");
//    Console.WriteLine("3. Save");
//    Console.WriteLine("0. Exit");
//    Console.WriteLine(":: :: :: :: :: :: :: :: ::");
//    Console.Write("Select an option: ");
//    return Console.ReadLine() ?? string.Empty;
//}