using System;
using TMPro;
using UnityEngine;


public class ButtonClick : MonoBehaviour
{
    public GameObject canvas;
    public GameObject headDoor;
    public TextMeshProUGUI inputUsername;

    public void ButtonClicked()
    {
        canvas.SetActive(false);
        Destroy(headDoor);
        string usernameBroken = inputUsername.text.ToString();
        string username = usernameBroken.Substring(0, usernameBroken.Length-1);
        Debug.Log(username);
        ManageServer.ServerManagement.callServerPostTime(Timer.myTime.ToString(), username);
    }
}
