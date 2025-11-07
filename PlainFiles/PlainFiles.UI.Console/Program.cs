using PlainFiles.Core;

var textFile = new SimpleTextFile(".//data//data.txt");
var lines = textFile.ReadAllLines().ToList();
var opt = string.Empty;

do
{
    opt = Menu();
    switch (opt)
    {
        case "1":
            Console.WriteLine("File content:");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
            break;
        case "2":
            Console.Write("Enter a new line: ");
            var newLine = Console.ReadLine();
            if (!string.IsNullOrEmpty(newLine))
            {
                lines.Add(newLine);
                Console.WriteLine("Line added.");
            }
            else
            {
                Console.WriteLine("No line entered.");
            }
            break;
        case "3":
            textFile.WriteAllLines(lines.ToArray());
            Console.WriteLine("File saved.");
            break;
        case "0":
            Console.WriteLine(":::::::::::::::::::::::::::::::");
            Console.WriteLine(":::::::::: GAME OVER ::::::::::");
            Console.WriteLine(": THANKS FOR USING OUR PROGRAM:");
            Console.WriteLine(":::::::: HAVE A GOD DAY :::::::");
            Console.WriteLine(":::::::::::::::::::::::::::::::");
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;

    }
    
}
while (opt != "0");
textFile.WriteAllLines(lines.ToArray());

string Menu()
{
    Console.WriteLine(":::::::::: MENÚ ::::::::::");
    Console.WriteLine();
    Console.WriteLine("1. Show file content.");
    Console.WriteLine("2. Add");
    Console.WriteLine("3. Save");
    Console.WriteLine("0. Exit");
    Console.WriteLine(":: :: :: :: :: :: :: :: ::");
    Console.Write("Select an option: ");
    return Console.ReadLine() ?? string.Empty;
}