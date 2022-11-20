using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;

    public GameObject canvasSelection;

    private void Start()
    {
        PhotonNetwork.Instantiate(playerPrefab.name, gameObject.transform.position, gameObject.transform.rotation);
    }
}
