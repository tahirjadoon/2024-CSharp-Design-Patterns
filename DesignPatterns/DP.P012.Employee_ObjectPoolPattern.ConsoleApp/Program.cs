// See https://aka.ms/new-console-template for more information
using DP.Core;
using DP.P012.Employee_ObjectPoolPattern.ConsoleApp;

ConsoleHelper.TitleWrite("ObjectPool Pattern implementation - Employee with ConcurrentBag!");
ConsoleHelper.WriteEmptyLine();

ObjectPool<Employee> pool = new ObjectPool<Employee>();

ConsoleHelper.WriteLine("Employee1 assigned");
var employee1 = pool.Get();

ConsoleHelper.WriteLine($"Pool count: {pool.PoolCount}", ConsoleColor.Yellow);

ConsoleHelper.WriteLine("Employee2 assigned");
var employee2 = pool.Get();

ConsoleHelper.WriteLine($"Pool count: {pool.PoolCount}", ConsoleColor.Yellow);

ConsoleHelper.WriteLine("Employee1 released", ConsoleColor.Cyan);
pool.Release(employee1);

ConsoleHelper.WriteLine($"Pool count: {pool.PoolCount}", ConsoleColor.Yellow);

ConsoleHelper.WriteLine("Employee3 assigned");
var employee3 = pool.Get();

ConsoleHelper.WriteLine($"Pool count: {pool.PoolCount}", ConsoleColor.Yellow);

ConsoleHelper.WriteLine("Employee2 released", ConsoleColor.Cyan);
pool.Release(employee2);

ConsoleHelper.WriteLine($"Pool count: {pool.PoolCount}", ConsoleColor.Yellow);

ConsoleHelper.WriteLine("Employee3 released", ConsoleColor.Cyan);
pool.Release(employee3);

ConsoleHelper.WriteLine($"Pool count: {pool.PoolCount}", ConsoleColor.Yellow);

ConsoleHelper.WriteLine("Employee4 assigned");
var employee4 = pool.Get();

ConsoleHelper.WriteLine($"Pool count: {pool.PoolCount}", ConsoleColor.Yellow);