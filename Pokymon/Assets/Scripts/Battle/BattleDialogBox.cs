using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleDialogBox : MonoBehaviour
{
    public Text dialogText;

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
}
