using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoad1 : MonoBehaviour
{
    public Card card;
    public Text numbercollection;
    public Image imageitem;
    // Start is called before the first frame update
    void Start()
    {
      
        numbercollection.text = card.number;
        imageitem.sprite = card.sprite;
    }

    // Update is called once per frame
  
}
