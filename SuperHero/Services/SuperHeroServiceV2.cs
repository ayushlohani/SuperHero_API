namespace SuperHero.Services
{
    public class SuperHeroServiceV2 : ISuperHeroService
    {
        private readonly DataContext _db;

        public SuperHeroServiceV2(DataContext db) {  _db = db; }
        public List<Hero> AddHero(Hero newhero)
        {
            if (_db.Heroes.ToList() == null) newhero.Id = 1;
            else newhero.Id = _db.Heroes.ToList().OrderByDescending(x => x.Id).FirstOrDefault().Id + 1;
            _db.Heroes.Add(newhero);
            _db.SaveChanges();
            return _db.Heroes.ToList();
        }

        public void DeleteHero(int id)
        {
            _db.Heroes.Remove(_db.Heroes.FirstOrDefault(x => x.Id == id));
            _db.SaveChanges();
        }

        public Hero GetHero(int id)
        {
            var hero = _db.Heroes.FirstOrDefault(x => x.Id == id);
            _db.SaveChanges();
            return hero;
        }

        public List<Hero> GetHeroes()
        {
            var heroes = _db.Heroes;

            return heroes.ToList();
        }

        public void updatedata(int id, Hero newHero)
        {
            var hero = _db.Heroes.FirstOrDefault(x => x.Id == id);
            hero.Id = id;
            hero.Name = newHero.Name;
            hero.Description = newHero.Description;
            hero.Title = newHero.Title;
            _db.SaveChanges();
        }
    }
}
