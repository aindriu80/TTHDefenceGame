namespace TeamTreeHouse
{
    public class VocabularyWord
    {
        public string Word { get; private set; }

        public VocabularyWord(string word)
        {
            Word = word;
        }

        public override string ToString()
        {
            return Word;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is VocabularyWord))
            {
                return false;
            }

            VocabularyWord that = obj as VocabularyWord;
            return this.Word.Equals(that.Word);


        }
    }
}
