using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class NewBehaviourScript : MonoBehaviour
{
    PhotonView pv;
    public GameObject Myplayer;

    // Start is called before the first frame update
    void Start()
    {
        pv=GetComponent<PhotonView>();
        int SpawnPicker = Random.Range(0, GameSetup.instance.spawnPoints.Length);
        if (pv.IsMine)
        {

         Myplayer=   PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "PhotonPlayer"),GameSetup.instance.spawnPoints[SpawnPicker].position,
                GameSetup.instance.spawnPoints[SpawnPicker].rotation,0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
