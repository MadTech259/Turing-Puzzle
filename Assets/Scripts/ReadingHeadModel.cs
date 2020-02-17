public class ReadingHeadModel : IReadingHeadModel
{
    private int _position;
  
    public int Position
    {
        get => _position;
        set => _position = value;
    }
}