using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;
using System.IO;

public class PhotonRoom : MonoBehaviourPunCallbacks,IInRoomCallbacks
{
    // Start is called before the first frame update
    public static PhotonRoom room;
    private PhotonView pv;
    public bool IsGameLoaded;
    public int CurrentScene;
    public int multiplayerscene;
    //playerInfo
    Player[] playerList;
    public int playerInRoom;
    public int MyNymberinRoom;
    public int MyNymberinGame;
    private void Awake()
    {
        if(PhotonRoom.room == null)
        {
            PhotonRoom.room = this;
        }
        else
        {
            if(PhotonRoom.room != this)
            {
                Destroy(PhotonRoom.room.gameObject);
                PhotonRoom.room = this;
            }
        }
        DontDestroyOnLoad(this.gameObject);
    }
    public override void OnEnable()
    {
        base.OnEnable();
        PhotonNetwork.AddCallbackTarget(this);
        SceneManager.sceneLoaded += OnSceneFinishedLoading;
    }
    public override void OnDisable()
    {
        base.OnDisable();
        PhotonNetwork.RemoveCallbackTarget(this);
        SceneManager.sceneLoaded -= OnSceneFinishedLoading;


    }
    void Start()
    {
        pv=GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        playerList = PhotonNetwork.PlayerList;
        Debug.Log("Joined the Room");
        {
            startgame();
        }
    }
    public void startgame()
    {
        if (!PhotonNetwork.IsMasterClient)
        {
            return;
        }
        PhotonNetwork.LoadLevel(multiplayerscene);
    }
    void OnSceneFinishedLoading(Scene scene,LoadSceneMode mode)
    {
        CurrentScene = scene.buildIndex;
        if(CurrentScene == multiplayerscene)
        {
            {
                CreatePlayer();
            }
        }
    }
    private void CreatePlayer()
    {
        PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs","PhotonNetworkPlayer"),transform.position,Quaternion.identity,0);
    }
    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        base.OnPlayerLeftRoom(otherPlayer);
        Debug.Log(otherPlayer.NickName + "Has left the game");
  
    }
}
