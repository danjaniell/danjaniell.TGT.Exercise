namespace TGT.Exercise.Service.Interface
{
    public interface IWordFindingStrategy
    {
        List<string> FindWords(List<string> words, string input);
    }

}
