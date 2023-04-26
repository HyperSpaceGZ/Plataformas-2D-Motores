using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIScript : MonoBehaviour
{
    public TMP_Text CoinsText;
    public TMP_Text JumpsText;
    public int Coins;
    private GameObject[] CoinsLeft;

    // Start is called before the first frame update
    void Start()
    {
        CoinsLeft = GameObject.FindGameObjectsWithTag("Coin");
        UIRefresh();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void UIRefresh()
    {
        CoinsText.text = "Coins: " + Coins + "/" + CoinsLeft.Length;
    }

    public void AddCoin()
    {
        Coins++;
        UIRefresh();
    }


}
