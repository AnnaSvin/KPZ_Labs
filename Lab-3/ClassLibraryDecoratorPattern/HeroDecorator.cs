public abstract class HeroDecorator : IHero
{
    protected IHero _hero;

    public HeroDecorator(IHero hero)
    {
        _hero = hero;
    }

    public virtual string GetDescription()
    {
        return _hero.GetDescription();
    }

    public virtual int GetPower()
    {
        return _hero.GetPower();
    }
}
