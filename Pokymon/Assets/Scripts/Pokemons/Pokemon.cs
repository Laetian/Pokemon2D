using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon
{
    private PokemonBase _pokemonBase;
    private int _pokemonLevel;
    private int _hp;
    public int Hp
    {
        get => _hp;
        set => _hp = value;
    }
    private List<Move> _moves;
    public List<Move> Moves
    {
        get => _moves;
        set => _moves = value;
    }

    public Pokemon(PokemonBase pokemonBase, int pokemonLevel)
    {
        _pokemonBase = pokemonBase;
        _pokemonLevel = pokemonLevel;
        _hp = _pokemonBase.MaxHP;
        _moves = new List<Move>();
        foreach (var lMove in _pokemonBase.LearnableMoves)
        {
            if(lMove.Level <= _pokemonLevel)
            {
                _moves.Add(new Move(lMove.Move));
            }
            if(_moves.Count >= 4)
            { 
                break;
            }
        }
    }

    public int MaxHP => Mathf.FloorToInt((_pokemonBase.MaxHP * _pokemonLevel) / 100.0f) + 10;
    public int Attack => Mathf.FloorToInt((_pokemonBase.Attack * _pokemonLevel) / 100.0f) + 3;
    public int Defense => Mathf.FloorToInt((_pokemonBase.Defense * _pokemonLevel) / 100.0f) + 3;
    public int SpAttack => Mathf.FloorToInt((_pokemonBase.SpAttack* _pokemonLevel) / 100.0f) + 3;
    public int SpDefense => Mathf.FloorToInt((_pokemonBase.SpDefense * _pokemonLevel) / 100.0f) + 3;
    public int Speed => Mathf.FloorToInt((_pokemonBase.Speed * _pokemonLevel) / 100.0f) + 3;

    //public List<moves> move;
}
