using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // Namespace for TextMeshPro

public class MainGameManager : MonoBehaviour
{
    public TextMeshProUGUI remainingAnimalsText;  // Use TextMeshProUGUI here

    private int remainingAnimals = 0;

    void Start()
    {
        if (remainingAnimalsText == null)
        {
            Debug.LogError("Missing TextMeshPro component.");
            return;
        }

        UpdateUI();
    }

    void UpdateUI()
    {
        if (remainingAnimalsText != null)
        {
            remainingAnimalsText.text = "" + remainingAnimals;
        }
    }


    public void OnAnimalDestroyed()
    {
        remainingAnimals++;
        UpdateUI();

        if (remainingAnimals >= 17)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        Debug.Log("All animals have been shot!");
    }
}
