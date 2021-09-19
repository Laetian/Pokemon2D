using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private GameObject healthBar;

    /// <summary>
    /// Refresh the health bar from the normalized value.
    /// </summary>
    /// <param name="normalizedValue">Health value normalized between 0 and 1.</param>
    public void SetHP(float normalizedValue)
    {
        healthBar.transform.localScale = new Vector3(normalizedValue, 1.0f, 1.0f);
    }
}
