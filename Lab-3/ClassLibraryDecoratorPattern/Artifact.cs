public class Artifact : HeroDecorator
{
    public Artifact(IHero hero) : base(hero) { }

    public override string GetDescription()
    {
        return base.GetDescription() + " + Artifact";
    }

    public override int GetPower()
    {
        return base.GetPower() + 7;
    }
}