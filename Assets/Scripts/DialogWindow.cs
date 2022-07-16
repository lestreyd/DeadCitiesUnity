using UnityEngine;
using UnityEngine.UI;

public class DialogWindow : MonoBehaviour
{
    public Text message;
    public Text[] answers;
    public GameObject trigger;

    // Start is called before the first frame update
    void Start()
    {
        message.text = "";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            message.text = "Hello, Username! How are you?";
            answers[0].text = "I'm fine! Thanks! And you?";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            message.text = "";
        }
    }
}
