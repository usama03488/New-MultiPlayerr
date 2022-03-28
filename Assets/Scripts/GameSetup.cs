using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSetup : MonoBehaviour
{
    public static GameSetup instance;
    public Transform[] spawnPoints;
    // Start is called before the first frame update
    private void OnEnable()
    {
        if (GameSetup.instance == null)
        {
           GameSetup.instance = this;
        }
     
    }
    public void DissconnectPlayer()
    {
        StartCoroutine(DissconnectAndLoad());
    }
    IEnumerator DissconnectAndLoad()
    {
        PhotonNetwork.Disconnect();
        while ( PhotonNetwork.IsConnected){
            yield return null;
            SceneManager.LoadScene(0);
        }
    }
}
