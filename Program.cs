namespace FirstLetterToEnd;
class Program
{
    static void Main(string[] args)
    {
        FirstLettertoEndMethod();
    }

    static void FirstLettertoEndMethod(){
        string[] words;
        string newWord;
        Back:
        string word = GetString();
        if((controlSpace(word) >0)){
            System.Console.WriteLine();
            words = word.Split(' ');
            foreach (var item in words)
            {
                newWord = CreateFirstLettertoEnd(item);
                System.Console.Write(newWord +" ");
            }
        }else if(controlSpace(word) ==-1){
            System.Console.WriteLine("Please, don't enter two or more spaces in a row. Please, enter again correctly.");
            goto Back;
        }
        else
        {
            newWord = CreateFirstLettertoEnd(word);
            System.Console.WriteLine(newWord);
        }
    }

    private static string CreateFirstLettertoEnd(string word)
    {
        string newWord ="";
        for (int i = 0; i < word.Length ; i++)
        {
            if (i!=0)
            {
                newWord += word[i]; 
            }
        }
        return newWord + word[0];
    }

    static string GetString(){
        System.Console.Write("Please, enter a word : ");
        return Console.ReadLine().Trim();
    }

    static int controlSpace(string word){
        int count = 0;
        char oldChar = new char();

        foreach (var item in word)
        {
            if(item == ' ' && oldChar == ' '){
                return -1;
            }
            else if(item ==' ')
            {
                count++;
            }
            oldChar = item;
        }

        return count;
    }
}
