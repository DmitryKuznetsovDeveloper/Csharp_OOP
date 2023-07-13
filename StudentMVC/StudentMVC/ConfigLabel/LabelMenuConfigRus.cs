namespace StudentMVC.ConfigLabel;

public class LabelMenuConfigRus : ILabelMenu
{
    private string _labelMenu = "1: LIST\n" + "2: DELETE\n" + "3: EXIT\n";
    private string _labelInputCommand = "Введите команду -> ";
    private string _labelDeleteStudent = "Какого ученика будем удалять ?";
    private string _labelExit = "Выход из программы !";
    private string _labelError = "Вы ввели неверную команду, попробуйте еще раз !";

    public string LabelMenu => _labelMenu;
    public string LabelInputCommand => _labelInputCommand;
    public string LabelDeleteStudent => _labelDeleteStudent;
    public string LabelExit => _labelExit;
    public string LabelError => _labelError;
}