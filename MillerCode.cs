using System;
using System.Text;

namespace MillerCode
{
    public class Miller
    {
        public string MilerCode(string inputSignal, int state0 = 0, int state1 = 1, string output = "")
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
        public string DecodeMiller(string str, string words = "")
        {
            for (int i = 0; i < str.Length; i += 2)
            {
                words += str.Substring(i, 2) + " ";
            }

            string[] word = words.Split(' ');
            string output = "";
            for (int i = 0; i < word.Length-1; i++)
            {
                if (word[i] == "00" || word[i] == "11")
                {
                    output += '0';
                }
                else
                {
                    output += '1';
                }
            }
            return output;
        }
        public string MFMCoder(string str)
        {
            string output = "";
            str = str + " ";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '0' && str[i + 1] == '0')
                {
                    output += "1";
                }
                else
                {
                    output += "0";
                }
            }
            if (str[0] != '1')
            {
                output = "?" + output;
            }
            StringBuilder OutputCoder = new StringBuilder();
            for (int i = 0; i < Math.Min(str.Length, output.Length); i++)
            {
                OutputCoder.Append(output[i]);
                OutputCoder.Append(str[i]);
            }
            var result = OutputCoder.ToString();
            return result;
        }

        public string MFMDecode(string str)
        {
            for (int i = 0; i < str.Length; i = i + 1)
            {
                str = str.Remove(i, 1);
            }
            return str;
        }
    }
}