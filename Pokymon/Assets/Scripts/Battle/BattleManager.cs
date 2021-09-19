using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    [SerializeField] private BattleUnit playerUnit;
    [SerializeField] private BattleHUD playerHUD;

    private void Start()
    {
        SetupBattle();
    }
    public void SetupBattle()
    {
        playerUnit.SetupPokemon();
        playerHUD.SetPokemonData(playerUnit.Pokemon);
    }
}
