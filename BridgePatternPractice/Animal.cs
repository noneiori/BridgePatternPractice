// See https://aka.ms/new-console-template for more information

/// <summary>
/// 動物抽象類別
/// </summary>
internal abstract class Animal
{
    IImplementor implementor;
    public Animal(IImplementor implementor)
    {
        this.implementor = implementor;
    }

    public void Feed()
    {
        this.implementor.Feed();
    }

    public void Touch()
    { this.implementor.Touch(); }
}