// See https://aka.ms/new-console-template for more information

/// <summary>
/// 危險動物的行為定義
/// </summary>
internal class DangerAnimalImplementor : IImplementor
{
    public void Feed()
    {
        Console.WriteLine("危險動物！只能遠處看飼育員餵食…");
    }

    public void Touch()
    {
        Console.WriteLine("危險動物不可碰觸！");
    }
}