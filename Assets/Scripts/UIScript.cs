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

    private PlayerScript PlayerScript;

    // Start is called before the first frame update
    void Start()
    {
        CoinsLeft = GameObject.FindGameObjectsWithTag("Coin");
        PlayerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
        UIRefresh();
        UIJumpRefresh();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void UIRefresh()
    {
        CoinsText.text = "Coins: " + Coins + "/" + CoinsLeft.Length;
    }

    public void UIJumpRefresh()
    {
        JumpsText.text = "Jumps: " + PlayerScript.jumpAmount;
    }

    public void AddCoin()
    {
        Coins++;
        UIRefresh();
    }

    public void AddJumpUI()
    {
        PlayerScript.jumpAmount++;
        PlayerScript.jumpAmount++;
        UIJumpRefresh();
    }

}
