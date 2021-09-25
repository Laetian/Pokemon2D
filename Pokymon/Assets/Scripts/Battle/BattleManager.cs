using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    [SerializeField] BattleUnit playerUnit;
    [SerializeField] BattleHUD playerHUD;
    [SerializeField] BattleUnit enemyUnit;
    [SerializeField] BattleHUD enemyHUD;

    [SerializeField] BattleDialogBox battleDialogBox;

    private void Start()
    {
        SetupBattle();
    }
    public void SetupBattle()
    {
        playerUnit.SetupPokemon();
        playerHUD.SetPokemonData(playerUnit.Pokemon);

        playerUnit.SetupPokemon();
        playerHUD.SetPokemonData(enemyUnit.Pokemon);

        battleDialogBox.SetDialog($"Un {enemyUnit.Pokemon.PokemonBase.PokemonName} salvaje apareció.");
    }
}
