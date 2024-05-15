using System;
using System.Collections.Generic;

public class Panther : Animal
{
	protected double _maxSpeed = 90.0;
    protected double _step = 15.0;
    protected double _speed = 0;
	protected bool _onTree = false;

	public override string Stop()
	{
		if (_speed == 0)
		{
            return "Пантера и так стоит";
        }

		_speed -= _step;

		if (_speed < 0)
		{
			_speed = 0;
		}

        return $"Скорость пантеры уменьшилась на {_step.ToString()}. \nТеперь скорость равна {_speed.ToString()}";
    }

	public override string Run()
	{
		if (_onTree)
		{
			return "Пантера на дереве";
		}

		if (_speed == _maxSpeed)
		{
			return $"Пантера уже бежит \nс максимальной скоростью {_maxSpeed.ToString()}";
        }

		_speed += _step;

		if (_speed > _maxSpeed)
		{
			_speed = _maxSpeed;
		}

		return $"Скорость пантеры увеличилась на {_step.ToString()}. \nТеперь скорость равна {_speed.ToString()}";
    }

    public override string GoUp()
    {
		if (_onTree)
		{
            return "Пантера и так на дереве";
        }

        _speed = 0;
        _onTree = true;

        return "Пантера залезла на дерево";
    }

    public override string GoDown()
    {
        if (!_onTree)
        {
            return "Пантера и так на земле";
        }

        _onTree = false;

        return "Пантера слезла с дерева";
    }

    public override string GetVoice()
    {
        return "pрррррр... мяy";
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