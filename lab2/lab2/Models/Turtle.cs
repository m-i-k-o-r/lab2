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
            return "�������� � ��� �����";
        }

        _speed -= _step;

        if (_speed < 0)
        {
            _speed = 0;
        }

        return $"�������� �������� ����������� �� {_step.ToString()}. \n������ �������� ����� {_speed.ToString()}";
    }

    public override string Run()
    {
        if (_speed == _maxSpeed)
        {
            return "�������� ��� ������������";
        }

        _speed += _step;

        if (_speed > _maxSpeed)
        {
            _speed = _maxSpeed;
        }

        return $"�������� �������� ����������� �� {_step.ToString()}. \n������ �������� ����� {_speed.ToString()}";
    }

    public override string GoUp()
    {
        _speed = 0;
        return "�������� ������������ � ����������� ������� �� ������, \n�� ������ ��� ��� �� �����";
    }

    public override string GoDown()
    {
        return "�������� �� �� ������ ����� ���� �� �������";
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
        return "�������� �� ���������� �� �����";
    }
}