using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Transitions : MonoBehaviour
{
    public Button backButton, acceptButton;
    public Canvas buttonsPanel;
    // Start is called before the first frame update
    void Start()
    {
        backButton.transform.localScale = new Vector3(0, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
