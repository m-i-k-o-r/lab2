using System;
using System.Collections.Generic;

public class Turtle : Animal
{
    protected double _maxSpeed = 15.0;
    protected double _step = 5.0;
    protected double _speed = 0;

    public override string Stop()
    {
        if (_speed == 0)
        {
            return "Черепаха и так стоит";
        }

        _speed -= _step;

        if (_speed < 0)
        {
            _speed = 0;
        }

        return $"Скорость черепахи уменьшилась на {_step.ToString()}. \nТеперь скорость равна {_speed.ToString()}";
    }

    public override string Run()
    {
        if (_speed == _maxSpeed)
        {
            return "Скорость уже максимальная";
        }

        _speed += _step;

        if (_speed > _maxSpeed)
        {
            _speed = _maxSpeed;
        }

        return $"Скорость черепахи увеличилась на {_step.ToString()}. \nТеперь скорость равна {_speed.ToString()}";
    }

    public override string GoUp()
    {
        _speed = 0;
        return "Черепаха остановилась и попробовала залезть на дерево, \nно поняла что она не может";
    }

    public override string GoDown()
    {
        return "Черепаха не на дереве чтобы куда то слазить";
    }


    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetMaxSpeed()
    {
        return _maxSpeed;
    }

    public override string GetVoice()
    {
        return "Черепаха не произнесла ни звука";
    }
}