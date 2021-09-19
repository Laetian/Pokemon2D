using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHUD : MonoBehaviour
{
    [SerializeField] private Text pokemonName;
    public Text PokemonName
    {
        get => pokemonName;
        set => pokemonName = value;
    }
    [SerializeField] private Text pokemonLevel;
    public Text PokemonLevel
    {
        get => pokemonLevel;
        set => pokemonLevel = value;
    }
    [SerializeField] private HealthBar healthBar;
    public HealthBar HealthBar
    {
        get => healthBar;
        set => healthBar = value;
    }
    [SerializeField] private Text pokemonHealth;
    private Text PokemonHealth
    {
        get => pokemonHealth;
        set => pokemonHealth = value;
    }
    public void SetPokemonData(Pokemon pokemon)
    {
        pokemonName.text = pokemon.PokemonBase.PokemonName;
        pokemonLevel.text = $"Lv: {pokemon.PokemonLevel}";
        healthBar.SetHP(pokemon.Hp/pokemon.MaxHP);
        pokemonHealth.text = $"{pokemon.Hp}/{pokemon.MaxHP}";
    }
}
