using System;
using System.Collections.Generic;
using System.Windows;

public class Dog : Animal
{
    protected double _maxSpeed = 40.0;
    protected double _step = 10.0;
    protected double _speed = 0;

    public override string Stop()
    {
        if (_speed == 0)
        {
            return "Собака и так стоит";
        }

        _speed -= _step;

        if (_speed < 0) 
        {  
            _speed = 0; 
        }
        
        return $"Скорость собаки уменьшилась на {_step.ToString()}. \nТеперь скорость равна {_speed.ToString()}";
    }

    public override string Run()
    {
        if (_speed == _maxSpeed)
        {
            return $"Собака уже бежит \nс максимальной скоростью {_maxSpeed.ToString()}";
        }

        _speed += _step;

        if (_speed > _maxSpeed)
        {
            _speed = _maxSpeed;
        }

        return $"Скорость собаки увеличилась на {_step.ToString()}. \nТеперь скорость равна {_speed.ToString()}"; ;
    }

    public override string GoUp()
    {
        _speed = 0;
        return "Собака остановилась и попробовала залезть на дерево, \nно поняла что она не может";
    }

    public override string GoDown()
    {
        return "Собака не на дереве, чтобы куда то слазить";
    }

    public override string GetVoice()
    {
        return "Гав гав гав";
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetMaxSpeed()
    {
        return _maxSpeed;
    }
}