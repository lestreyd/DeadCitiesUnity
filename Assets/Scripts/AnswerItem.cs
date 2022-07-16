using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerItem : MonoBehaviour
{
    public GameObject trigger;

    public void onClick()
    {
        Debug.Log("Clicked");
        DialogWindow script = trigger.GetComponent<DialogWindow>();
        if (script != null)
        {
            script.answers[0].text = "";
            script.message.text = "I'm too!";
            StartCoroutine("DelayClose");
        }
    }

    IEnumerator DelayClose()
    {
        yield return new WaitForSeconds(2);
        DialogWindow script = trigger.GetComponent<DialogWindow>();
        if (script != null)
        {
            script.message.text = "";
        }
    }
}
