using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="Move", menuName ="Pokemon/Nuevo Movimiento")]
public class MoveBase : ScriptableObject
{
    [SerializeField] private string name;
    [TextArea] [SerializeField] private string description;
    [SerializeField] private PokemonType type;
    [SerializeField] private int power;
    [SerializeField] private int accurazy;
    [SerializeField] private int pp;//number of times can be used
}
