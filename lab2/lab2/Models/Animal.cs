
public abstract class Animal
{
    protected double _maxSpeed;
    protected double _speed;


    public abstract string Stop();
    public abstract string Run();
    public abstract string GoUp();
    public abstract string GoDown();
    public abstract string GetVoice();
    public abstract double GetSpeed();
    public abstract double GetMaxSpeed();
}