using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidDeath : MonoBehaviour
{
    [SerializeField]
    public Health playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        playerHealth.currentHealth = 0;
        playerHealth.Die();
    }
}
