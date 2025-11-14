using PlainFiles.Core;


Console.Write("Enter the list name: ");
var listName = Console.ReadLine();  

var helper = new NugetCsvHelper();
var people = helper.Read($"{listName}.csv").ToList();
foreach (var person in people)
{
    Console.WriteLine($"ID: {person.Id}, Name: {person.FirstName}, Age: {person.Age}");
}







//MAIN PROGRAM USING MANUALCSVHELPER

//Console.Write("Enter the list name: ");
//var listName = Console.ReadLine();
//var manualCsv = new ManualCsvHelper();
//var people = manualCsv.ReadCsv($"{listName}.csv");
//var option = string.Empty;

//do
//{
//    option = MyMenu();
//    switch(option)
//    {
//        case "1":
//            AddPerson();
//            break;
//        case "2":
//            ListPeople();
//            break;
//        case "3":
//            SaveFile(people, listName);
//            Console.WriteLine("List saved.");
//            break;
//        case "4":
//            DeletePerson();
//            break;
//        case "5":
//            SortData();
//            break;
//        case "0":
//            Console.WriteLine(":::::::::::::::::::::::::::::::");
//            Console.WriteLine(":::::::::: GAME OVER ::::::::::");
//            Console.WriteLine(": THANKS FOR USING OUR PROGRAM:");
//            Console.WriteLine(":::::::: HAVE A GOD DAY :::::::");
//            Console.WriteLine(":::::::::::::::::::::::::::::::");
//            break;
//        default:
//            Console.WriteLine("Invalid option. Please try again.");
//            break;
//    }
//}
//while (option != "0");
//SaveFile(people, listName);

//string MyMenu()
//{
//    Console.WriteLine();
//    Console.WriteLine("1. Add.");
//    Console.WriteLine("2. Show list.");
//    Console.WriteLine("3. Save");
//    Console.WriteLine("4. Delete");
//    Console.WriteLine("5. Sort");
//    Console.WriteLine("0. Exit.");
//    Console.Write("Select an option: ");
//    return Console.ReadLine() ?? string.Empty;
//}

//void AddPerson()
//{
//    Console.Write("Enter first name: ");
//    var firstName = Console.ReadLine();
//    Console.Write("Enter last name: ");
//    var lastName = Console.ReadLine();
//    Console.Write("Enter age: ");
//    var age = Console.ReadLine();
//    people.Add([firstName ?? string.Empty, lastName ?? string.Empty, age ?? string.Empty]);
//}

//void ListPeople()
//{
//    if (people.Count == 0)
//    {
//        Console.WriteLine("The list is empty.");
//        return;
//    }
//    Console.WriteLine($"Current list: {listName}");
//    Console.WriteLine();
//    Console.WriteLine("-------------------------------------------");
//    Console.WriteLine("   NAMES\t|   SURNAMES\t|   AGES");
//    Console.WriteLine("-------------------------------------------");
//    Console.WriteLine();
//    foreach (var person in people)
//    {
//        Console.WriteLine($"{person[0],-10}\t|{person[1],-10}\t|{person[2],-10}\t");
//    }
//    Console.WriteLine("___________________________________________");
//}

//void DeletePerson()
//{
//    Console.Write("Enter the name to delete: ");
//    var nameToDelete = Console.ReadLine();
//    var peopleToDelete = people
//        .Where(p => p[0].Equals(nameToDelete, StringComparison.OrdinalIgnoreCase))
//        .ToList();
//    if (peopleToDelete.Count == 0)
//    {
//        Console.WriteLine("No matching person found.");
//        return;
//    }

//    for (int i = 0; i < peopleToDelete.Count; i++)
//    {
//        Console.WriteLine($"ID: {i} - Nombres: {peopleToDelete[i][0]} {peopleToDelete[i][1]}, Edad: {peopleToDelete[i][2]}");
//    }

//    int id;
//    do
//    {
//        Console.Write("Enter the ID of the item you want to delete, or -1 to cancel: ");
//        var idString = Console.ReadLine();
//        int.TryParse(idString, out id);
//        if (id < -1 || id > peopleToDelete.Count)
//        {
//            Console.WriteLine("Invalid ID. Please try again.");
//        }
//    }while (id < -1 || id > peopleToDelete.Count);

//    if (id == -1)
//    {
//        Console.WriteLine("Deletion cancelled.");
//        return;
//    }

//    var personToRemove = peopleToDelete[id];
//    people.Remove(personToRemove);
//}

//void SortData()
//{
//    int order;
//    do
//    {
//        Console.Write("Sort by: 0. First name, 1. Last name, 2. Age? ");
//        var orderString = Console.ReadLine();
//        int.TryParse(orderString, out order);
//        if (order < 0 || order > 2)
//        {
//            Console.WriteLine("Invalid option. Please try again.");
//        }
//    } while (order < 0 || order > 2);

//    int type;
//    do
//    {
//        Console.Write("You want to sort: 0. Ascending order, 1. Descending order? ");
//        var typeString = Console.ReadLine();
//        int.TryParse(typeString, out type);
//        if (type < 0 || type > 1)
//        {
//            Console.WriteLine("Invalid option. Please try again.");
//        }
//    } while (type < 0 || type > 1);

//    people.Sort((a, b) =>
//    {
//        int cmp;
//        if (order == 2)
//        {
//            bool parsedA = int.TryParse(a[2], out int ageA);
//            bool parsedB = int.TryParse(b[2], out int ageB);

//            if (!parsedA) ageA = int.MinValue;
//            if (!parsedB) ageB = int.MinValue;

//            cmp = ageA.CompareTo(ageB);
//        }
//        else
//        {
//            cmp = string.Compare(a[order], b[order], StringComparison.OrdinalIgnoreCase);
//        }
//        return type == 0 ? cmp : -cmp;
//    });
//    Console.WriteLine("List sorted successfully.");
//}

//void SaveFile(List<string[]> people, string? listName)
//{
//    manualCsv.WriteCsv($"{listName}.csv", people);
//}


//CLASS MANUALCSVHELPER USAGE EXAMPLE
//var people = new List<string[]>
//{
//    new[] { "FirstName", "LastName", "Age" },
//    new[] { "John", "Doe", "30" },
//    new[] { "Jane", "Smith", "25" },
//    new[] { "Sam", "Brown", "40" }
//};

//var manualCsv = new ManualCsvHelper();
//manualCsv.WriteCsv("people.csv", people);

//var loaded = manualCsv.ReadCsv("people.csv");
//foreach (var person in loaded)
//{
//    Console.WriteLine(string.Join("|", person));
//}

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