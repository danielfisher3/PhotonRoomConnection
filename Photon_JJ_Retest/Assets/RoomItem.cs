using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RoomItem : MonoBehaviour
{
    public TMP_Text roomName;
    LobbyManager manager;

    private void Start()
    {
        manager = FindObjectOfType<LobbyManager>();
    }
    public void SetRoomName(string _roomname)
    {
        roomName.text = _roomname;
    }

    public void OnClickItem()
    {
        manager.JoinRoom(roomName.text);
    }
}
