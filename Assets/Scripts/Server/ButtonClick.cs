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
        string username = inputUsername.text.ToString();
        Debug.Log(username);
        ManageServer.ServerManagement.callServerPostTime(Timer.myTime.ToString(), username);
    }
}
