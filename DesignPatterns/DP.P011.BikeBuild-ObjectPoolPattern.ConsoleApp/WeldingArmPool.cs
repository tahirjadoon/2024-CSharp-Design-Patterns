using DP.BicycleBuildBase.Robotics.Arms;

namespace DP.P011.BikeBuild_ObjectPoolPattern.ConsoleApp;

public class WeldingArmPool
{
    private int _maxSize = 10;

    private List<WeldingArm> Pool { get; set; } = null!;
    public int ArmsAvailable => Pool.Count;

    public WeldingArmPool()
    {
        Reset();   
    }

    public int MaxSize
    {
        get => _maxSize;
        set
        {
            _maxSize = value;
            Reset();
        }
    }

    public void Reset()
    {
        Pool = new List<WeldingArm>();
        for(var i=0; i< MaxSize; i++)
        {
            Pool.Add(new WeldingArm());
        }
    }

    public WeldingArm GetArmFromPool()
    {
        if(ArmsAvailable > 0)
        {
            var returnArm = Pool[0];
            Pool.RemoveAt(0);
            return returnArm;
        }
        throw new Exception("You are out of arms. Return some to the pool and try again");
    }

    public void ReturnArmToPool(WeldingArm arm)
    {
        arm.CurrentPosition = 0; //not at any station
        Pool.Add(arm);
    }
}
