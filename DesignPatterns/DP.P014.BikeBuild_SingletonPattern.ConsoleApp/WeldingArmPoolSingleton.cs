using DP.BicycleBuildBase.Robotics.Arms;

namespace DP.P014.BikeBuild_SingletonPattern.ConsoleApp;

/// <summary>
/// sealed class and constructor is private
/// </summary>
public sealed class WeldingArmPoolSingleton
{
    private static readonly Lazy<WeldingArmPoolSingleton> _lazyInstance = new Lazy<WeldingArmPoolSingleton>(() => new WeldingArmPoolSingleton());
    public static WeldingArmPoolSingleton Instance { get { return _lazyInstance.Value; } }

    private int _maxSize = 10;

    private List<WeldingArm> Pool { get; set; } = null!;
    public int ArmsAvailable => Pool.Count;

    private WeldingArmPoolSingleton()
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
        for (var i = 0; i < MaxSize; i++)
        {
            Pool.Add(new WeldingArm());
        }
    }

    public WeldingArm GetArmFromPool()
    {
        if (ArmsAvailable > 0)
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
