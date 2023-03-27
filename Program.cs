using System;

class MillerCode
{
    static void Main(string[] args)
    {
        string input = "1011101010";

        //string signal = MilerCode(input);
        String str = "01111001100001111000";
        string words = "";
        for (int i = 0; i < str.Length; i += 2) {
        words += str.Substring(i, 2) + " ";
        }

        string[] word = words.Split(' ');
        string output = "";
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == "00" || word[i] == "11"){
                output += '0';
            }else{
                output += '1';
            }
        }
        Console.WriteLine(output);
        
    }
    public static String MilerCode(String inputSignal, int state0 = 0, int state1 = 1, String output = "")
    {
        for (int i = 0; i < inputSignal.Length; i++)
        {
            if (inputSignal[i] == '1')
            {
                if (state1 == 1)
                {
                    output += "01";
                    state1 = 3;
                    state0 = 2;
                }
                else if (state1 == 3)
                {
                    output += "10";
                    state1 = 1;
                    state0 = 0;
                }
                else if (state1 == 2)
                {
                    output += "11";
                    state1 = 3;
                    state0 = 0;
                }
                else if (state1 == 0)
                {
                    output += "00";
                    state1 = 1;
                    state0 = 2;
                }
            }
            else if (inputSignal[i] == '0')
            {
                if (state0 == 3)
                {
                    output += "10";
                    state1 = 1;
                    state0 = 0;
                }
                else if (state0 == 2)
                {
                    output += "11";
                    state0 = 0;
                    state1 = 3;
                }
                else if (state0 == 1)
                {
                    output += "01";
                    state0 = 2;
                    state1 = 3;
                }
                else if (state0 == 0)
                {
                    output += "00";
                    state0 = 2;
                    state1 = 1;
                }
            }
        }
        return output;
    }
           static List<string> SplitString(string str)
        {
            List<string> list = new List<string>();
            int i = 0;
            while (i < str.Length - 1)
            {
                list.Add(str.Substring(i, 2));
                i += 2;
            }
            return list;
        }
}
