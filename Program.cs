// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//1. Iterate and print values

static void PrintList(List<string> MyList)
{

    foreach(string names in MyList){
        Console.WriteLine(names);
    }
}
List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};
PrintList(TestStringList);


