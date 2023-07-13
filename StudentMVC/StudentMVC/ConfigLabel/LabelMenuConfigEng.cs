using StudentMVC.ConfigLabel;

namespace StudentMVC.View;

public class LabelMenuConfigEng : ILabelMenu
{
    private string _labelMenu = "1: LIST\n" + "2: DELETE\n" + "3: EXIT\n";
    private string _labelInputCommand = "Enter command -> ";
    private string _labelDeleteStudent = "Which student will be removed ?";
    private string _labelExit = "Exiting the program!";
    private string _labelError = "You entered the wrong command, please try again !";

    public string LabelMenu => _labelMenu;
    public string LabelInputCommand => _labelInputCommand;
    public string LabelDeleteStudent => _labelDeleteStudent;
    public string LabelExit => _labelExit;
    public string LabelError => _labelError;
}
