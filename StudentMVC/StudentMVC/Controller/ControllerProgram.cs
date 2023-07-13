using StudentMVC.ConfigLabel;
using static StudentMVC.Controller.Commands;
namespace StudentMVC.Controller;

public class ControllerProgram
{
    private IGetModel _model;
    private IGetView _view;
    private ILabelMenu _labelMenu;
    private ILabelStudent _labelStudent;

    public ControllerProgram(IGetModel model, IGetView view, ILabelMenu labelMenu, ILabelStudent labelStudent) {
        _model = model;
        _view = view;
        _labelMenu = labelMenu;
        _labelStudent = labelStudent;
    }

    public void Run()
    {
        bool getNewIteration = true;
        while (getNewIteration)
        {
            Console.WriteLine(_labelMenu.LabelMenu);
            string userCommand = _view.Prompt(_labelMenu.LabelInputCommand);
            try
            {
                Commands command = Enum.Parse<Commands>(userCommand.ToUpper());
                switch (command)
                {
                    //TODO : возможно доработки 
                    /*case NONE:
                        break;
                    case READ:
                        break;
                    case CREATE:
                        break;
                    case UPDATE:
                        break;*/
                    case LIST:
                        Console.WriteLine($"{new string('=',16)} {_labelStudent.LabelListStudent} {new string('=',16)}");
                        _view.PrintAllStudents(_model.StudentsDictionary);
                        Console.WriteLine(new string('=',50));
                        break;

                    case DELETE:
                        Console.WriteLine(_labelMenu.LabelDeleteStudent);
                        _model.SearchStudent(Convert.ToInt64(Console.ReadLine()));
                        _model.DeleteStudent();
                        break;

                    case EXIT:
                        getNewIteration = false;
                        Console.WriteLine(_labelMenu.LabelExit);
                        break;
                }
            }
            catch (Exception )
            {
                Console.WriteLine(new string('=',60));
                Console.WriteLine(_labelMenu.LabelError);
                Console.WriteLine(new string('=',60));
            }
        }
    }
}