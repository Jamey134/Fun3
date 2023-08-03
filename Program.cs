// Console.WriteLine("Hello, World!");


// //1. Iterate and print values

// static void PrintList(List<string> MyList)
// {

//     foreach(string names in MyList){
//         Console.WriteLine(names);
//     }
// }
// List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};
// PrintList(TestStringList);

// // 2. Print Sum

// static void SumOfNumbers(List<int> IntList)
// {
//     int result = 0;
//     for (var i = 0; i < IntList.Count; i++){
//         {
//         result = result + IntList[i];

//     }
//     Console.WriteLine(result);
//     }
// }
// List<int> TestIntList = new List<int>() {2,7,12,9,3};
// // You should get back 33 in this example
// SumOfNumbers(TestIntList);

// // 3. Find Max

// static int FindMax(List<int> IntList)

// {
//     int max = 0;

//     for (int i = 0; i < IntList.Count; i++)
//     {
//         if(max < IntList[i]){
//             max = IntList[i];
//         }
//     }
//     return max;
// }   
// List<int> TestIntList2 = new List<int>() {-9,12,10,3,17,5};
// // You should get back 17 in this example
// FindMax(TestIntList2);
// Console.WriteLine(FindMax(TestIntList2));


// 4. Square the Values

// static List<int> SquareValues(List<int> IntList)
// {
//     for (int i = 0; i < IntList.Count; i++)
//     {
//         // IntList[i] *= IntList[i];
//         Console.WriteLine(IntList[i] + ":" + i);
//     }
//     foreach (int item in IntList)
//     {
//         Console.WriteLine(item);
//     }
//     return IntList;
// }
// List<int> TestIntList3 = new List<int>() {1,2,3,4,5};
// // You should get back [1,4,9,16,25], think about how you will show that this worked
// SquareValues(TestIntList3);


// 5. Replace Negative Numbers with 0

internal class Program
{
    private static void Main(string[] args)
    {
        static int[] NonNegatives(int[] IntArray)
        {
            for (int i = 0; i < IntArray.Length; i++)
            {
                if (IntArray[i] < 0)
                {
                    IntArray[i] = 0;
                }
                Console.WriteLine(IntArray[i]);
            }
            return IntArray;
        }

        int[] TestIntArray = new int[] { -1, 2, 3, -4, 5 };
        Console.WriteLine(NonNegatives(TestIntArray));
        // You should get back [0,2,3,0,5], think about how you will show that this worked
        NonNegatives(TestIntArray);

        // 6. Print Dictionary

        static void PrintDictionary(Dictionary<string, string> MyDictionary)
        {
            foreach (var value in MyDictionary)
            {
                Console.WriteLine(value);
            }
        }
        Dictionary<string, string> TestDict = new Dictionary<string, string>();
        TestDict.Add("HeroName", "Iron Man");
        TestDict.Add("RealName", "Tony Stark");
        TestDict.Add("Powers", "Money and intelligence");
        PrintDictionary(TestDict);


        // 7. Find Key

        static bool FindKey(Dictionary<string, string> MyDictionary, string SearchTerm)
        {
            // Your code here (I will need a condition to find a key)

            Boolean check = false;
            foreach (var key in MyDictionary.Keys)
            {
                Console.WriteLine("--->" + key);
                Console.WriteLine("+++" + SearchTerm);
                if (key == SearchTerm)
                {

                    check = true;
                    break;

                }
            }
            return check;
            //     if (MyDictionary.ContainsKey(SearchTerm)){

            //     return true;

            //     }

            //     else
            //     {
            //         return false;
            //     }
            // }
            // return true;
        }

        // Use the TestDict from the earlier example or make your own
        // This should print true
        Console.WriteLine(FindKey(TestDict, "RealName"));
        // This should print false
        Console.WriteLine(FindKey(TestDict, "Name"));

    




// static Dictionary<string, int> GenerateDictionary(List<string> Names, List<int> Numbers)
// {

//     foreach (var key in Names)
//     {
//         foreach (var value in Numbers) {
//             Console.WriteLine(key + ":" + value);

//         }
//     }


//     Dictionary<string, int> test = new Dictionary<string,int>();
//     return test;
// }
// List<string> Names = new List<string>();
// Names.Add("Julie");
// Names.Add("Harold");
// Names.Add("James");
// Names.Add("Monica");

// List<int> Numbers = new List<int>();
// Numbers.Add(6);
// Numbers.Add(12);
// Numbers.Add(7);
// Numbers.Add(10);

// Console.WriteLine(GenerateDictionary(Names, Numbers));
// // We've shown several examples of how to set your tests up properly, it's your turn to set it up!
// // Your test code here

//     }
// }

// 8. Generate a Dictionary

// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//	"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 

Dictionary<string,int> GenerateDictionary=new Dictionary<string, int>();

GenerateDictionary.Add("Julie",6);
GenerateDictionary.Add("Harold",12);
GenerateDictionary.Add("James",7);
GenerateDictionary.Add("Monica",10);
{

foreach(KeyValuePair<string,int> entry in GenerateDictionary)
{
    Console.WriteLine($"{entry.Key}:{entry.Value}");
}
}
Console.WriteLine(GenerateDictionary);
    }
}
// We've shown several examples of how to set your tests up properly, it's your turn to set it up!
// Your test code here