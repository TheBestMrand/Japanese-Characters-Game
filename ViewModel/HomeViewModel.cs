using JapaneseCharactersGame.Model;

namespace JapaneseCharactersGame.ViewModel;

public class HomeViewModel
{
    private readonly HiraganaCharacter[] _hiraganaCharacters;

    private HiraganaCharacter _currentHiraganaCharacter = new("あ", "a");
    private List<HiraganaCharacter> _currentHiraganaAllowedCharacters = new();
    
    public HiraganaCharacter[] HiraganaCharacters => _hiraganaCharacters;
    public HiraganaCharacter CurrentHiraganaCharacter => _currentHiraganaCharacter;

    public HomeViewModel()
    {
        _hiraganaCharacters = new HiraganaCharacter[48];
        _hiraganaCharacters[0] = new HiraganaCharacter("あ", "a");
        _hiraganaCharacters[1] = new HiraganaCharacter("い", "i");
        _hiraganaCharacters[2] = new HiraganaCharacter("う", "u");
        _hiraganaCharacters[3] = new HiraganaCharacter("え", "e");
        _hiraganaCharacters[4] = new HiraganaCharacter("お", "o");
        _hiraganaCharacters[5] = new HiraganaCharacter("か", "ka");
        _hiraganaCharacters[6] = new HiraganaCharacter("き", "ki");
        _hiraganaCharacters[7] = new HiraganaCharacter("く", "ku");
        _hiraganaCharacters[8] = new HiraganaCharacter("け", "ke");
        _hiraganaCharacters[9] = new HiraganaCharacter("こ", "ko");
        _hiraganaCharacters[10] = new HiraganaCharacter("さ", "sa");
        _hiraganaCharacters[11] = new HiraganaCharacter("し", "shi");
        _hiraganaCharacters[12] = new HiraganaCharacter("す", "su");
        _hiraganaCharacters[13] = new HiraganaCharacter("せ", "se");
        _hiraganaCharacters[14] = new HiraganaCharacter("そ", "so");
        _hiraganaCharacters[15] = new HiraganaCharacter("た", "ta");
        _hiraganaCharacters[16] = new HiraganaCharacter("ち", "chi");
        _hiraganaCharacters[17] = new HiraganaCharacter("つ", "tsu");
        _hiraganaCharacters[18] = new HiraganaCharacter("て", "te");
        _hiraganaCharacters[19] = new HiraganaCharacter("と", "to");
        _hiraganaCharacters[20] = new HiraganaCharacter("な", "na");
        _hiraganaCharacters[21] = new HiraganaCharacter("に", "ni");
        _hiraganaCharacters[22] = new HiraganaCharacter("ぬ", "nu");
        _hiraganaCharacters[23] = new HiraganaCharacter("ね", "ne");
        _hiraganaCharacters[24] = new HiraganaCharacter("の", "no");
        _hiraganaCharacters[25] = new HiraganaCharacter("は", "ha");
        _hiraganaCharacters[26] = new HiraganaCharacter("ひ", "hi");
        _hiraganaCharacters[27] = new HiraganaCharacter("ふ", "fu");
        _hiraganaCharacters[28] = new HiraganaCharacter("へ", "he");
        _hiraganaCharacters[29] = new HiraganaCharacter("ほ", "ho");
        _hiraganaCharacters[30] = new HiraganaCharacter("ま", "ma");
        _hiraganaCharacters[31] = new HiraganaCharacter("み", "mi");
        _hiraganaCharacters[32] = new HiraganaCharacter("む", "mu");
        _hiraganaCharacters[33] = new HiraganaCharacter("め", "me");
        _hiraganaCharacters[34] = new HiraganaCharacter("も", "mo");
        _hiraganaCharacters[35] = new HiraganaCharacter("や", "ya");
        _hiraganaCharacters[36] = new HiraganaCharacter("ゆ", "yu");
        _hiraganaCharacters[37] = new HiraganaCharacter("よ", "yo");
        _hiraganaCharacters[38] = new HiraganaCharacter("ら", "ra");
        _hiraganaCharacters[39] = new HiraganaCharacter("り", "ri");
        _hiraganaCharacters[40] = new HiraganaCharacter("る", "ru");
        _hiraganaCharacters[41] = new HiraganaCharacter("れ", "re");
        _hiraganaCharacters[42] = new HiraganaCharacter("ろ", "ro");
        _hiraganaCharacters[43] = new HiraganaCharacter("わ", "wa");
        _hiraganaCharacters[44] = new HiraganaCharacter("を", "wo");
        _hiraganaCharacters[45] = new HiraganaCharacter("ん", "n");
        _hiraganaCharacters[46] = new HiraganaCharacter("が", "ga");
        _hiraganaCharacters[47] = new HiraganaCharacter("ぎ", "gi");
    }

    public void SetCurrentAllowedCharacters(List<string> allowedCharacters)
    {
        _currentHiraganaAllowedCharacters = new List<HiraganaCharacter>();
        foreach (var character in _hiraganaCharacters)
        {
            if (allowedCharacters.Contains(character.Character))
            {
                _currentHiraganaAllowedCharacters.Add(character);
            }
        }
    }
    
    public void SetCurrentHiraganaCharacter()
    {
        Random random = new Random();
        _currentHiraganaCharacter = _currentHiraganaAllowedCharacters[random.Next(0, _currentHiraganaAllowedCharacters.Count)];
    }
    
}