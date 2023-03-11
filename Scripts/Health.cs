using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    public static Health Instance;

    public HPBar healthBar;

    public int currentHealth;

    public int Lives = 3;

    void Start()

    {
        currentHealth = Lives;
        healthBar.SetMaxHealth(Lives);
    }

    private void Update()
    {
        if (Lives < 0)
        {
            Destroy(gameObject);
        }
    }

    public void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        
    }
}