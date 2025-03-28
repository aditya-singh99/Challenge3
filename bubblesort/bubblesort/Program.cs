using System.Collections.Generic; //to import Collections

List<int> prefilledList = new List<int> { 34, 7, 23, 32, 5, 62 };
List<int> userList = new List<int>();
bool exit = false;

//Code menu section with options
while (!exit)
{
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1. Use prefilled list");
    Console.WriteLine("2. Enter a new list");
    Console.WriteLine("3. Exit");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1": //for predefined list
            Console.WriteLine("Prefilled list before sorting:");
            DisplayList(prefilledList);
            BubbleSort(prefilledList);
            Console.WriteLine("Prefilled list after sorting:");
            DisplayList(prefilledList);
            break;

        case "2": //for taking user input
            userList.Clear();
            Console.WriteLine("Enter numbers separated by spaces:");
            string input = Console.ReadLine();
            string[] inputs = input.Split(' ');
            foreach (string number in inputs)
            {
                if (int.TryParse(number, out int num))
                {
                    userList.Add(num);
                }
            }
            Console.WriteLine("User list before sorting:");
            DisplayList(userList);
            BubbleSort(userList);
            Console.WriteLine("User list after sorting:");
            DisplayList(userList);
            break;

        case "3": //for exiting program
            exit = true;
            break;

        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}

//bubble sort logic
static void BubbleSort(List<int> list)
{
    for (int i = 0; i < list.Count - 1; i++)
    {
        for (int j = 0; j < list.Count - 1 - i; j++)
        {
            if (list[j] > list[j + 1])
            {
                int temp = list[j];
                list[j] = list[j + 1];
                list[j + 1] = temp;
            }
        }
    }
}


//function for displaying list
static void DisplayList(List<int> list)
{
    foreach (int num in list)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}