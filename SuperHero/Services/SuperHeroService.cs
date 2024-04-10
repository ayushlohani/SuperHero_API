
namespace SuperHero.Services
{
    public class SuperHeroService : ISuperHeroService
    {
        public List<Hero> AddHero(Hero newhero)
        {
            newhero.Id = Store.superheroList.OrderByDescending(x => x.Id).FirstOrDefault().Id + 1;
            Store.superheroList.Add(newhero);
            return Store.superheroList;
        }

        public void DeleteHero(int id)
        {
            Store.superheroList.Remove(Store.superheroList.FirstOrDefault(x => x.Id == id));
        }

        public Hero GetHero(int id)
        {
            var hero = Store.superheroList.FirstOrDefault(x => x.Id == id);
            return hero;
        }

        public List<Hero> GetHeroes()
        {
            var heroes = Store.superheroList;
            return heroes;
        }

        public void updatedata(int id, Hero newHero)
        {
            var hero = Store.superheroList.FirstOrDefault(x => x.Id == id);
            hero.Id = id;
            hero.Name = newHero.Name;
            hero.Description = newHero.Description;
            hero.Title = newHero.Title;
        }
    }
}
