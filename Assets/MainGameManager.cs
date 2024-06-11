using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // Namespace for TextMeshPro

public class MainGameManager : MonoBehaviour
{
    public TextMeshProUGUI remainingAnimalsText;  // Use TextMeshProUGUI here

    private int shotsFired = 0;
    private int remainingAnimals;

    void Start()
    {
        if (remainingAnimalsText == null)
        {
            Debug.LogError("Missing TextMeshPro component.");
            return;
        }

        remainingAnimals = GameObject.FindGameObjectsWithTag("Animal").Length;
        UpdateUI();
    }

    void UpdateUI()
    {
        remainingAnimals = GameObject.FindGameObjectsWithTag("Animal").Length;
        if (remainingAnimalsText != null)
        {
            remainingAnimalsText.text = "Animals Left: " + remainingAnimals;
        }
    }

    public void OnAnimalShot()
    {
        shotsFired++;
        UpdateUI();
    }

    public void OnAnimalDestroyed()
    {
        remainingAnimals--;
        UpdateUI();

        if (remainingAnimals <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        Debug.Log("All animals have been shot!");
    }
}
