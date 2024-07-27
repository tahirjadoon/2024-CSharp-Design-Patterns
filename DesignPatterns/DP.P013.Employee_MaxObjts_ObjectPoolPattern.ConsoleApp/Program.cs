// See https://aka.ms/new-console-template for more information
using DP.Core;
using DP.P013.Employee_MaxObjts_ObjectPoolPattern.ConsoleApp;

ConsoleHelper.TitleWrite("ObjectPool Pattern implementation - Employee with ConcurrentBag - Max new objectsize 5!");
ConsoleHelper.WriteEmptyLine();

int maxSize = 5;

ConsoleHelper.WriteLine("Creating pool object wit max size 5");
var pool = new ObjectPool<Employee>(maxSize, () => new Employee());
ConsoleHelper.WriteEmptyLine();

ConsoleHelper.WriteLine($"Pool count: {pool.PoolCount}", ConsoleColor.Yellow);
ConsoleHelper.WriteEmptyLine();

List<Employee> list = new List<Employee>();

for(var i=0; i< maxSize; i++)
{
    var emp = Get("Employee", i + 1);
    list.Add(emp);

    if(i > 0)
    {
        Random rnd = new Random();
        int rndIndex = rnd.Next(0, 10);  // creates a number between 0 and 9
        if (rndIndex <= list.Count -1)
            Release("Employee", rndIndex);
    }
}

Employee  Get(string title, int index)
{
    ConsoleHelper.WriteLine($"Get {title} {index}", ConsoleColor.Green);
    var emp = pool.Get();
    ConsoleHelper.WriteLine($"Pool count: {pool.PoolCount}", ConsoleColor.Yellow);
    ConsoleHelper.WriteEmptyLine();
    return emp;
}

void Release(string title, int index)
{
    ConsoleHelper.WriteLine($"Release {title} {index+1}", ConsoleColor.Red);
    pool.Release(list[index]);
    list.RemoveAt(index);
    ConsoleHelper.WriteLine($"Pool count: {pool.PoolCount}", ConsoleColor.Yellow);
    ConsoleHelper.WriteEmptyLine();
}

