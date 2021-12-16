using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleState 
{
    StartBattle,
    PlayerSelectAction,
    PlayerMove,
    EnemyMove,
    Busy
}

public class BattleManager : MonoBehaviour
{
    [SerializeField] BattleUnit playerUnit;
    [SerializeField] BattleHUD playerHUD;
    [SerializeField] BattleUnit enemyUnit;
    [SerializeField] BattleHUD enemyHUD;

    [SerializeField] BattleDialogBox battleDialogBox;

    public BattleState state;

    private void Start()
    {
        StartCoroutine(SetupBattle());
    }
    public IEnumerator SetupBattle()
    {
        state = BattleState.StartBattle;
        playerUnit.SetupPokemon();
        playerHUD.SetPokemonData(playerUnit.Pokemon);

        enemyUnit.SetupPokemon();
        enemyHUD.SetPokemonData(enemyUnit.Pokemon);

        yield return battleDialogBox.SetDialog($"Un {enemyUnit.Pokemon.PokemonBase.PokemonName} salvaje apareció.");
        yield return new WaitForSeconds(1.0f);

        if (enemyUnit.Pokemon.Speed > playerUnit.Pokemon.Speed)
        {
            StartCoroutine(battleDialogBox.SetDialog("The enemy attack fisrt!"));
            EnemyAction();
        }
        else
        {
            PlayerAction();
        }
    }
    void PlayerAction()
    {
        state = BattleState.PlayerSelectAction;
        StartCoroutine(battleDialogBox.SetDialog("Select an action"));
        battleDialogBox.ToogleActions(true);
    }
    void EnemyAction()
    {

    }
    private void Update()
    {
        if (state== BattleState.PlayerSelectAction)
        {
            HandlePlayerActionSelection();
        }
    }

    private int currentSelectedAction;
 
    void HandlePlayerActionSelection()
    {
        if (Input.GetAxisRaw("Vertical")!=0)
            {
                if (currentSelectedAction==0)
                    {
                    currentSelectedAction++;
                    }
                else if(currentSelectedAction == 1)
                        {
                    currentSelectedAction--;
                        }
            battleDialogBox.SelectAction(currentSelectedAction);
        }
    }


}
