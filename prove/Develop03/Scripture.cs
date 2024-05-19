using System.Runtime.Intrinsics.Arm;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(" ");
        
        foreach (string word in words)
        {
            Word w = new Word(word);
            _words.Add(w);
        }
       
        
    }
    public void HideRandomWords(int numberToHide)
    {
        List<int> randWordsIndex = new List<int>();
        List<int> randWordsToIndexHide = new List<int>();
        
        int num = 0;
        foreach (Word word in _words)
        {
            if (word.GetDisplayText() != "_____")
            {
                randWordsIndex.Add(num);
            }             
            int val = num + 1;
            num = val;     
        }

        for (int d=1; d<=numberToHide; d++)
        {
            Random random = new Random();
            int index = random.Next(randWordsIndex.Count);


            if (randWordsIndex.Count != 0)
            {
                randWordsToIndexHide.Add(randWordsIndex[index]);
                randWordsIndex.Remove(randWordsIndex[index]);
            }          
            
        }

        randWordsToIndexHide.Sort();
        foreach (int number in randWordsToIndexHide)
        {
            _words[number].Hide();
        }

    }
    public string GetDisplayText()
    {
        string full_text = "";
        foreach (Word word in _words)
        {
        full_text += word.GetDisplayText() + " ";
        }
        
        return full_text;
    }
    public bool IsCompletelyHidden()
    {
        string word_full = GetDisplayText();
       
        word_full = word_full.Replace(" ","");
        if(word_full.Distinct().Count() == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

}