using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Bring in Photon Pun Namespace for multiplayer functionality
using Photon.Pun;
using TMPro;

public class ConnectToServer : MonoBehaviourPunCallbacks
{
    public TMP_InputField userNameInput;
    public TMP_Text buttonText;


    public void OnClickConnect()
    {
        if(userNameInput.text.Length >= 1)
        {
            PhotonNetwork.NickName = userNameInput.text;
            buttonText.text = "Connecting...";
            PhotonNetwork.AutomaticallySyncScene = true;
            PhotonNetwork.ConnectUsingSettings();
        }
    }


    /// <summary>
    /// Called when connnected to main server
    /// </summary>
    public override void OnConnectedToMaster()
    {
        SceneManager.LoadScene("Lobby");
    }
}
