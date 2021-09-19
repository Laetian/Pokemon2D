using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private GameObject healthBar;
    private void Start()
    {
        healthBar.transform.localScale = new Vector3(0.5f, 1.0f, 1.0f);
    }
}
