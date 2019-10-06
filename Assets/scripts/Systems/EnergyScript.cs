using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyScript : MonoBehaviour
{
    public static readonly int maxEnergy = 30;
    public static int curEnergy = 0;
    private GameplayManager gameplayManager;

    void Awake()
    {
        gameplayManager = GameObject.FindObjectOfType<GameplayManager>();
    }
    void Start()
    {
        StartCoroutine(addEnergy());
    }

    IEnumerator addEnergy()
    {
        while (true)
        { // loops forever...
            if (curEnergy < maxEnergy)
            {
                curEnergy += 1;
                yield return new WaitForSeconds(60);
            }
            else
            {
                yield return null;
       
            }
            gameplayManager.UpdateEnergy(curEnergy);
        }
    }
}
