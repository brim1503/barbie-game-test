using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehaviour : MonoBehaviour
{

    //[SerializeField] private messageInput;
    // Start is called before the first frame update
    private bool displaySymbolError = false;
    public GameObject errorText;
    public InputField inputField;
    public Button submitButton;
    

    //private gameObject submitButton;
    void Start()
    {
        submitButton.onClick.AddListener(OnSubmit);
    }

    void Update()
    {
    }

    void OnSubmit()
    {
        string input = inputField.text;
        if (Regex.IsMatch(input, "^[a-zA-Z0-9 ]*$"))
        {
            displaySymbolError = false;
        }
        else
        {
            displaySymbolError = true;
        }
        errorText.SetActive(displaySymbolError);
        inputField.Select();
        inputField.text = "";
    }
}
