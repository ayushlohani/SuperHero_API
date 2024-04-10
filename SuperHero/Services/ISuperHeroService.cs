namespace SuperHero.Services
{
    public interface ISuperHeroService
    {
        List<Hero> GetHeroes();

        Hero GetHero(int id);

        void AddHero(Hero newhero);

        void DeleteHero(int id);

        void updatedata(int id, Hero hero);
    }
}
