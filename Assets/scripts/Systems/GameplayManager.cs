using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayManager : MonoBehaviour
{
    public Text energyText;
    private int currentEnergy;
    // Start is called before the first frame update
public void UpdateEnergy(int energy)
    {
        currentEnergy += energy;
      energyText.text = "Energy: " + currentEnergy.ToString();
    }

}
