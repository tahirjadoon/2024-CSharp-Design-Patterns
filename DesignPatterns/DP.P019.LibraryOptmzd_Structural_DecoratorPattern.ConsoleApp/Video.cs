using DP.Core;

namespace DP.P019.LibraryOptmzd_Structural_DecoratorPattern.ConsoleApp;

public class Video : AbstractGenericLibraryItem<Video>
{
    private string _director;
    private string _title;
    private int _playTime;

    public Video(string director, string title, int playTime, int numCopies)
    {
        _director = director;
        _title = title;
        _playTime = playTime;
        base.NumCopies = numCopies;
    }


    public override void Display()
    {
        ConsoleHelper.WriteLine($"\tVideo => [Director={_director}, Title={_title}], PlayTime={_playTime}, NumCopies={base.NumCopies}]", ConsoleColor.Yellow);
    }
}
