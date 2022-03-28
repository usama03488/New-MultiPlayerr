using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PhotonLobby : MonoBehaviourPunCallbacks
{
    public static PhotonLobby instance;
    public GameObject BattleButton;
    public GameObject CancelButton;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
    public override void OnConnectedToMaster()
    {
        Debug.Log("player connected to master");
        PhotonNetwork.AutomaticallySyncScene = true;
      BattleButton.SetActive(true);
    }
    public void OnBatlleButtonClicked()
    {
        Debug.Log("Battle Button Clicked");
        BattleButton.SetActive(false);
        CancelButton.SetActive(true);
        PhotonNetwork.JoinRandomRoom();
    }
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("Failed to join Random Room");
      CreatRoom();
    }
    void CreatRoom()
    {
        Debug.Log("Room creating");
        int Randomroom = Random.Range(0, 1000);
        RoomOptions roomOps = new RoomOptions() { IsVisible = true, IsOpen = true, MaxPlayers = 5 };
        PhotonNetwork.CreateRoom("room" + Randomroom, roomOps);
    }
 
    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("Tried to create a new room but failed");
        CreatRoom();
    }
    public void OnCancelButtonClicked()
    {
        Debug.Log("Cancel buttpn pressed");
        BattleButton.SetActive(true);
        CancelButton.SetActive(false);
        PhotonNetwork.LeaveRoom();
    }
    // Update is called once per frame
    void Update()
    {
      

    }
}
