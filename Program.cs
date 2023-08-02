// // See https://aka.ms/new-console-template for more information
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

static int[] NonNegatives(int[] IntArray)
{
    for (int i = 0; i < IntArray.Length; i++)
    {
        if (IntArray[i] < 0){
            IntArray[i] = 0;
        }
        Console.WriteLine(IntArray[i]);
    }
            return IntArray;
}

int[] TestIntArray = new int[] {-1,2,3,-4,5};
    Console.WriteLine(NonNegatives(TestIntArray));
// You should get back [0,2,3,0,5], think about how you will show that this worked
NonNegatives(TestIntArray);


