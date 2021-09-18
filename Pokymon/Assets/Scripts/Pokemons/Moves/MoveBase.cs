using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="Move", menuName ="Pokemon/Nuevo Movimiento")]
public class MoveBase : ScriptableObject
{
    [SerializeField] private string moveName;
    public string MoveName => moveName;
    [TextArea] [SerializeField] private string description;
    [SerializeField] private PokemonType type;
    public PokemonType Type => type;
    [SerializeField] private int power;
    public int Power => power;
    [SerializeField] private int accuracy;
    public int Accuracy => accuracy;
    [SerializeField] private int pp;//number of times can be used
    public int Pp => pp;
}
