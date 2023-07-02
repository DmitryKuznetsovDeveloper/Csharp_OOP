namespace Supermarket.Interface;

public interface ITermsAction
{
    private static int MaxNumberAction { get;}
    public static int ParticipatingCounter { get; set; }
    public int CounterAction { get; set; }
    public string ShareName { get; set; }
    public bool IssueShare(int maxNuberAction, int counterAction );
}