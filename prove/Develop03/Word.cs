class Word
{    
    private string _word;
    private bool _hidden;

    public Word(string word, bool hidden)
    {
        _word = word;
        _hidden = hidden;
    }
    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }
    public void Hide(){
        _hidden = true;
    }
    public void Show(){
        _hidden = false;
    }
    public string GetWord(){
        if(_hidden){
            string hiddenWord = "";
            for(int i = 0; i < _word.Length; i++){
                hiddenWord += "_";
            }
            return hiddenWord;
        }
        else{
            return _word;
        }
    }
    public bool IsHidden(){
        return _hidden;
    }

}
