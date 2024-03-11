namespace JapaneseCharactersGame.Model;

public class HiraganaCharacter(string character, string asInput) : ISymbol
{
    public string Character { get; } = character;
    public string AsInput { get; } = asInput;
    
    public override string ToString()
    {
        return Character;
    }
}