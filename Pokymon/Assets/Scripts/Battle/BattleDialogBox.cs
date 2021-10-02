using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleDialogBox : MonoBehaviour
{
    [SerializeField] Text dialogText;
    [SerializeField] GameObject actionSelect;
    [SerializeField] GameObject movementSelect;
    [SerializeField] GameObject movementDesc;

    [SerializeField] List<Text> actionText;
    [SerializeField] List<Text> movementText;

    [SerializeField] Text ppText;
    [SerializeField] Text typetext;

    [SerializeField] float charactersPerSecond;

    public IEnumerator SetDialog(string message)
    {
        dialogText.text = "";
        foreach(var character in message)
        {
            dialogText.text += character;
            yield return new WaitForSeconds(1/charactersPerSecond);
        }
    }

    public void ToggleDialogText(bool activated)
    {
        dialogText.enabled = activated;
    }

    public void ToogleActions(bool activated)
    {
        actionSelect.SetActive(activated);
    }

    public void ToogleMovements(bool activated)
    {
        movementSelect.SetActive(activated);
        movementDesc.SetActive(activated);
    }
    public void SelectAction(int selectedAction)
    {
        for (int i = 0; i < actionText.Count; i++)
        {
            if (i == selectedAction)
            {
                actionText[i].color = selectedColor;
            }
            else
            {
                actionText[i].color = Color.black;
            }
        }
    }
}
