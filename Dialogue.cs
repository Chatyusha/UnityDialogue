using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public void TextDialogue(Text text,string message, float time)
    {
        StartCoroutine(IEDialogue(text, message, time));
    }

    IEnumerator IEDialogue(Text text, string message, float time)
    {
        foreach(var c in message)
        {
            text.text += c;
            yield return new WaitForSeconds(time / message.Length);
        }
    }
}
