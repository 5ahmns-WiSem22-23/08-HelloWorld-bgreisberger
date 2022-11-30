using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HelloWorldUI : MonoBehaviour
{
    [SerializeField]
    private Text inputText;
    [SerializeField]
    private TextMeshProUGUI outputText;

    public void ShowText()
    {
        outputText.text = inputText.text;
    }
}
