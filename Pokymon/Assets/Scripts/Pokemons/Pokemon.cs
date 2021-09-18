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

    public int MaxHP => Mathf.FloorToInt((_pokemonBase.MaxHP * _pokemonLevel) / 100.0f) + 10;
    public int Attack => Mathf.FloorToInt((_pokemonBase.Attack * _pokemonLevel) / 100.0f) + 3;
    public int Defense => Mathf.FloorToInt((_pokemonBase.Defense * _pokemonLevel) / 100.0f) + 3;
    public int SpAttack => Mathf.FloorToInt((_pokemonBase.SpAttack* _pokemonLevel) / 100.0f) + 3;
    public int SpDefense => Mathf.FloorToInt((_pokemonBase.SpDefense * _pokemonLevel) / 100.0f) + 3;
    public int Speed => Mathf.FloorToInt((_pokemonBase.Speed * _pokemonLevel) / 100.0f) + 3;
}
