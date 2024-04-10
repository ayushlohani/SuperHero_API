namespace SuperHero.data
{
    public static class Store
    {
        public static List<Hero> superheroList = new List<Hero>
        {
            new Hero{Id = 1,Name = "Bruce Wayne",Title = "Batman",Description="A boy who lost his parent and choose the path of vengence"},
            new Hero{Id = 2,Name = "Peter Parker",Title = "Spider-man",Description="A friendly neighbourhood"},
            new Hero{Id = 3,Name = "Tony Stark",Title = "Iron-man",Description="A Techie save the world by creating suit"}
        };
    }
}
