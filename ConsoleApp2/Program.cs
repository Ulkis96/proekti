string[] arr = Console.ReadLine().Split().ToArray();
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] cmd = Console.ReadLine().Split().ToArray();

    string command = cmd[0];
    switch (command)
    {
        case "Reverse":
            arr = arr.Reverse().ToArray();
            break;
        case "Distinct":
            arr = arr.Distinct().ToArray();
            break;
        case "Replace":
            int index = int.Parse(cmd[1]);
            string newString = cmd[2];
            arr[index] = newString;
            break;
        default:
            break;
    }
}
Console.WriteLine(string.Join(", ", arr));