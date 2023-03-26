﻿using System;

class MillerCode
{
    static void Main(string[] args)
    {
        string input = "1011101010"; // входные данные
        string output = ""; // выходные данные
        int state1 = 1; // начальное состояние
        int state0 = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '1')
            {
                if (state1 == 1 )
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
                    state1= 1;
                    state0= 2;
                }
            }
            else if (input[i] == '0')
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
                    state1= 3;
                }
                else if (state0 == 0)
                {
                    output += "00";
                    state0 = 2;
                    state1 = 1;
                }
            }
        }

        Console.WriteLine(output); // выводим результат
    }
}