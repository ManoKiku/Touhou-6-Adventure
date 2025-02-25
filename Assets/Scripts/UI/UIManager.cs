using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text hpText;
    [SerializeField]
    private Text powerText;
    [SerializeField]
    private Text bombText;
    [SerializeField]
    private Text scoreText;
    private void Update() {
        hpText.text = $"HP {PlayerStatus.instance.hp} - 5";
        powerText.text = $"PW {PlayerStatus.instance.powerAmount} - 128";
        bombText.text = $"BM {PlayerStatus.instance.bombAmount} - 5";
        scoreText.text = $"Score {PlayerStatus.instance.score}";
    }
}
