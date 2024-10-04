internal class Program
{
/*
    static int Add(int a, int b) => a + b;
    static int Sub(int a, int b) => a - b;
    static int Mul(int a, int b) => a * b;
    static int Div(int a, int b) => a / b;
 
    private static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        string op = Console.ReadLine();

        switch(op)
        {
            case "+":
            {
                Add(x,y);
                break;
            }
            case "-":
            {
                Sub(x,y);
                break;
            }
            case "*":
            {
                Mul(x,y);
                break;
            }
            case "/":
            {
                Div(x,y);
                break;
            }
            default:
            {
                Console.WriteLine("Invalid Operator");
                break;
            }

        }
        
    }
*/

//-------------------------------------------------

/*
    static void Names(string[] input)
    {
        string[] names = { "alpha", "beta", "gamma", "delta", "epsilon" };
        bool found = false;

        for (int i = 0; i < names.Length; i++)
        {
            if (input[0] == names[i]) 
            { 
                Console.WriteLine($"The name {input[0]} is present");
                found = true;
                break;  
            }
        }

        if (!found)
        {
            Console.WriteLine("Name not present");
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a name : ");
        string input = Console.ReadLine();
        input = input.ToLower();  
        Names(new string[] { input });
    }

*/

//----------------------------------------
/*   static void Names(string[] input)
    {
        string[] names = { "alpha", "beta", "gamma", "delta", "epsilon", "alice", "bob", "cathy", "david","ernie"};
        bool found = false;

        for (int i = 0; i < names.Length; i++)
        {
            if (input[0] == names[i])
            { 
                Console.WriteLine($"The name {input[0]} is present");
                found = true;
                break;  
            }
            /*
            if (names[i].StartsWith(inputLetter.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(names[i]);
                found = true;
            }
            
        }

        if (!found)
        {
            Console.WriteLine("Name not present");
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a name : ");
        string input = Console.ReadLine().ToLower().Trim(); 
        Names(new string[] { input });
  
    }
*/
//--------------------------------
   /* System.Console.WriteLine("Enter a sentence : ");
    string sent = Console.ReadLine();

    System.Console.WriteLine("Enter the text to be replaced : ");
    string text = Console.ReadLine();

    System.Console.WriteLine("Enter the text to be replaced with : ");
    string replace = Console.ReadLine();

    Console.WriteLine(sent.Replace(text,replace));

*/
//-------------------------------
    private static void Main(string[] args)
    {
    /*
        System.Console.Write("Enter a sentence : ");
        string line = Console.ReadLine();

        string[] words = line.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            int count = 0;
            string word = words[i];

            bool counted = false;

            for(int j = 0; j < words.Length ; j++)
            {
                if (words[j] == word)
                {
                    counted = true;
                }
            }

            if(counted == true)
            {
                for(int k = 0; k < words.Length ; k++)
                {
                    if (words[k] == word)
                    {
                        count++;
                    }
                }

                Console.WriteLine($"'{word}' : {count}");
            }

        }
    */


    //foreach
    /*
       string text = "This is a long long long sentence";
       string[] words = text.Split(' ');
       string[] found = new string[words.Length];
       int checker = 0;

       foreach(var word in words)
       {
        if(found.Contains(words))
            continue;

        int count = 0;

        foreach(var item in words)
        {
            if(item == word)
                count++;
        }

        found[counter] = word;
        counter++;

        Console.WriteLine($"'{word}' : {count}");

        }
      
        */


        //----------------------------------

        /*
        System.Console.Write("Enter a word to check if it's a palindrome : ");
        string word = Console.ReadLine();

        string rev = new string(word.Reverse().ToArray());

        if(rev == word)
        {
            System.Console.WriteLine("The string is a palindrome");
        }

        else
        {
            System.Console.WriteLine("Not a palindrome");
        }

        */

        //-----------------------------------

        


    }


    
}


