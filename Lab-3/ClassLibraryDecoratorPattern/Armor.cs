public class Armor : HeroDecorator
{
    public Armor(IHero hero) : base(hero) { }

    public override string GetDescription()
    {
        return base.GetDescription() + " + Armor";
    }

    public override int GetPower()
    {
        return base.GetPower() + 3;
    }
}