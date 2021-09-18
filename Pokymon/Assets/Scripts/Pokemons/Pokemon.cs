using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon
{
    private PokemonBase _pokemonBase;
    private int _pokemonLevel;

    public Pokemon(PokemonBase pokemonBase, int pokemonLevel)
    {
        _pokemonBase = pokemonBase;
        _pokemonLevel = pokemonLevel;
    }
}
