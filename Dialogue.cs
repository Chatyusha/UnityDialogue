using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Dialogue : MonoBehaviour
{
    public void TextDialogue(Text text,string message, float time, Action beforeFunc=null, Action afterFunc = null)
    {
        
        StartCoroutine(IEDialogue(text, message, time,beforeFunc,afterFunc));
    }

    IEnumerator IEDialogue(Text text, string message, float time, Action beforeFunc = null, Action afterFunc=null)
    {
        if (beforeFunc != null)
        {
            beforeFunc();
        }
        foreach (var c in message)
        {
            text.text += c;
            yield return new WaitForSeconds(time / message.Length);
        }
        if (afterFunc != null)
        {
            afterFunc();
        }
    }

    internal void TextDialogue(Text text, string msg, int v1, object v2)
    {
        throw new NotImplementedException();
    }
}
