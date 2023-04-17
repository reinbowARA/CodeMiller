using MillerCode;
internal class Test
{
    private static void Main(string[] args)
    {
        string input = "01011101010";
        var miller = new MillerCode.Miller();
        
        string signal = miller.MilerCode(input);
        string OutputSignal = miller.DecodeMiller(signal);
        string value = miller.MFMCoder(input);
        string v = miller.MFMDecode(value);

        Console.WriteLine("Кодирование по коду Миллера: " + signal);
        Console.WriteLine("Декодирование кода Миллера: "+  OutputSignal);
        Console.WriteLine("MFM кодирование сигнала: " + value);
        Console.WriteLine("MFM декодирование сигнала:: "+ v);
    }
}