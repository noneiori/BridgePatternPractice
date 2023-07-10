// See https://aka.ms/new-console-template for more information

/// <summary>
/// 可愛動物的行為定義
/// </summary>
internal class CuteAnimalImplementor : IImplementor
{
    public void Feed()
    {
        Console.WriteLine("可愛動物餵食中…");
    }

    public void Touch()
    {
        Console.WriteLine("摸摸可愛動物");
    }
}