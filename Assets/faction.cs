using UnityEngine;
using System.Collections;

public class Faction {

    public Sprite Logo;
    public string Name, Description, Tech, PoliticalRegime, Aspirations;

    public Faction(Sprite logo, string name, string description, string tech, string politicalRegime, string aspirations)
    {
        Logo = logo;
        Name = name;
        Description = description;
        Tech = tech;
        PoliticalRegime = politicalRegime;
        Aspirations = aspirations;
    }
}
