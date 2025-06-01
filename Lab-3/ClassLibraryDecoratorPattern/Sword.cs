public class Sword : HeroDecorator
{
    public Sword(IHero hero) : base(hero) { }

    public override string GetDescription()
    {
        return base.GetDescription() + " + Sword";
    }

    public override int GetPower()
    {
        return base.GetPower() + 5;
    }
}