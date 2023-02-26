using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using TMPro;

public class PersonNameLimits : MonoBehaviour
{
    public TMP_InputField personNameInputField;

    public void PersonNameOnValueChanged()
    {
        string fieldText = personNameInputField.text;
        if (!Regex.Match(fieldText, @"\w").Success || !(fieldText.Length <= 16))
        {
            if (fieldText.Length == 0) { return; }
            personNameInputField.text = fieldText.Remove(fieldText.Length - 1);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
