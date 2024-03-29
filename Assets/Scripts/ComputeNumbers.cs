﻿using UnityEngine;
using UnityEngine.UI;

public class ComputeNumbers : MonoBehaviour
{
    public Text result;
    public InputField ipfVarA;
    public InputField ipfVarB;
    public Button btnSubNumbers;
    public Button btnReset;

    // Start is called before the first frame update
    void Start()
    {
    btnReset.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetOnClick()
    {
    ipfVarA.interactable = true;
    ipfVarB.interactable = true;
    btnSubNumbers.interactable = true;
    btnReset.interactable = false;
    result.text = "Result";
    ipfVarA.text = "";
    ipfVarB.text = "";
    //result.text = 0;
    }
    public void SubNumbersOnClick()
    {
        int variableA = int.Parse(ipfVarA.text);
        int variableB = int.Parse(ipfVarB.text);
        int SubResult = variableA - variableB;
        result.text = SubResult.ToString();
        ipfVarA.interactable = false;
        ipfVarB.interactable = false;
        btnSubNumbers.interactable = false;
        btnReset.interactable = true;
    }



}
