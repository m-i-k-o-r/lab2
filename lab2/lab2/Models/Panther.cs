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
            return "������� � ��� �����";
        }

		_speed -= _step;

		if (_speed < 0)
		{
			_speed = 0;
		}

        return $"�������� ������� ����������� �� {_step.ToString()}. \n������ �������� ����� {_speed.ToString()}";
    }

	public override string Run()
	{
		if (_onTree)
		{
			return "������� �� ������";
		}

		if (_speed == _maxSpeed)
		{
			return $"������� ��� ����� \n� ������������ ��������� {_maxSpeed.ToString()}";
        }

		_speed += _step;

		if (_speed > _maxSpeed)
		{
			_speed = _maxSpeed;
		}

		return $"�������� ������� ����������� �� {_step.ToString()}. \n������ �������� ����� {_speed.ToString()}";
    }

    public override string GoUp()
    {
		if (_onTree)
		{
            return "������� � ��� �� ������";
        }

        _speed = 0;
        _onTree = true;

        return "������� ������� �� ������";
    }

    public override string GoDown()
    {
        if (!_onTree)
        {
            return "������� � ��� �� �����";
        }

        _onTree = false;

        return "������� ������ � ������";
    }

    public override string GetVoice()
    {
        return "p������... ��y";
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