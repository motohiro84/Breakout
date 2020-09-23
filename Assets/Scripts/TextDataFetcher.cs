using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDataFetcher : MonoBehaviour {

    public Text resultMessageText;
    public Text resultTitleText;

    // Use this for initialization
    void Start () {
        resultTitleText.text = DataSender.resultTitle;
        resultMessageText.text = DataSender.resultMessage;
    }

    // Update is called once per frame
    void Update () {

    }
}