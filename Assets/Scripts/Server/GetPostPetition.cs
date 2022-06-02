using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPostPetition : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ManageServer.ServerManagement.callServerGetResults();

    }

}
    