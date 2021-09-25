using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleDialogBox : MonoBehaviour
{
    public Text dialogText;
    public void SetDialog(string message)
    {
        dialogText.text = message;
    }
}
