using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardDisplay : MonoBehaviour
{
    public Card familiar1;

    public Text nameText;
    public Sprite artwork;
    public Text maxlvltext;
    public Text Rarity;
    public Text currentLevel;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = familiar1.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
