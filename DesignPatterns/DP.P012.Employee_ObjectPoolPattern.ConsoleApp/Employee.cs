namespace DP.P012.Employee_ObjectPoolPattern.ConsoleApp;

public class Employee
{
    private string _firstName = string.Empty;
    private int _empoyeeId = 0;

    public string Name 
    { 
        get { return _firstName; } 
        set { _firstName = value; }
    }

    public int  Id 
    { 
        get { return _empoyeeId; } 
        set { _empoyeeId = value; }
    }
}
