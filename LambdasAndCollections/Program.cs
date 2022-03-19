using System;
using System.Collections.Generic;

var heroes = new List<Hero>
{
    new("Wade","Wilson","Deadpool",false),
    new(string.Empty,string.Empty,"Homelander",true),
    new("Bruce","Wayne","Batman",false),
    new(string.Empty,string.Empty,"Stormfront",true)
};

var result = FilterHeroesWhoCanFly(heroes);
var heroesWhoCanFly = string.Join(", ", result);
Console.WriteLine(heroesWhoCanFly);

List<Hero> FilterHeroesWhoCanFly(List<Hero> heroes)
{
    var resultList = new List<Hero>();
    foreach (var hero in heroes)
    {
        if (hero.CanFly)
        {
            resultList.Add(hero);
        }
    }

    return resultList;
}
record Hero(string FirstName, string LastName, string HeroName, bool CanFly);