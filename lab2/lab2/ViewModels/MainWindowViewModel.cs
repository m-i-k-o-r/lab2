using Prism.Commands;
using Prism.Mvvm;
using System.Windows;

public class MainWindowViewModel : BindableBase
{
    public DelegateCommand DogCommand { get; set; }
    public DelegateCommand PantherCommand { get; set; }
    public DelegateCommand TurtleCommand { get; set; }

    public DelegateCommand StopCommand { get; set; }
    public DelegateCommand RunCommand { get; set; }
    public DelegateCommand GoUpCommand { get; set; }
    public DelegateCommand GoDownCommand { get; set; }
    public DelegateCommand VoiceCommand { get; set; }

    public DelegateCommand OutputCommand { get; set; }

    private Animal _animal;
    private string _data = "животное не выбрано";
    
    public MainWindowViewModel()
    {
        DogCommand = new DelegateCommand(Dog);
        PantherCommand = new DelegateCommand(Panther);
        TurtleCommand = new DelegateCommand(Turtle);

        RunCommand = new DelegateCommand(Run);
        StopCommand = new DelegateCommand(Stop);

        GoUpCommand = new DelegateCommand(Up);
        GoDownCommand = new DelegateCommand(Down);

        VoiceCommand = new DelegateCommand(Voice);
        Data = _data;
    }

    private void Dog()
    {
        _animal = new Dog();
        Data = $"Выбрана Собака. \nУ нее максимальная скорость равна {_animal.GetMaxSpeed()}. \nНе может лазить по деревьям и Может подать голос";
    }

    private void Panther()
    {
        _animal = new Panther();
        Data = $"Выбрана Пантера. \nУ нее максимальная скорость равна {_animal.GetMaxSpeed()}. \nМожет лазить по деревьям и Может подать голос";
    }

    private void Turtle()
    {
        _animal = new Turtle();
        Data = $"Выбрана Черепаха. \nУ нее максимальная скорость равна {_animal.GetMaxSpeed()}. \nНе может лазить по деревьям и Не может подать голос";
    }

    private void Stop()
    {
        if (_animal != null)
        {
            Data = _animal.Stop();
        }
        else
        {
            Data = _data;
        }
    }

    private void Run()
    {
        if(_animal != null)
        {
            Data = _animal.Run();
        }
        else
        {
            Data = _data;
        }
    }

    private void Up()
    {
        if (_animal != null)
        {
            Data = _animal.GoUp();
        }
        else
        {
            Data = _data;
        }
    }

    private void Down()
    {
        if (_animal != null)
        {
            Data = _animal.GoDown();
        }
        else
        {
            Data = _data;
        }
    }

    private void Voice()
    {
        if (_animal != null)
        {
            Data = _animal.GetVoice();
        }
        else
        {
            Data = _data;
        }
    }

    public string Data
    {
        get => _data;
        set => SetProperty(ref _data, value);
    }
}