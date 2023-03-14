using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;
public class fonksiyonveKodlar : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {

        // sunucuya bağlan
        // lobiye bağlan
        // odaya bağlan
      /*PhotonNetwork.ConnectUsingSettings(); // servera bağlanma isteği yapıldı
        PhotonNetwork.JoinLobby(); // lobiye bağlan
        PhotonNetwork.JoinRoom("oda ismi"); // odaya bağlan
        PhotonNetwork.JoinRandomRoom(); // rasgele bir odaya bağlan
        PhotonNetwork.CreateRoom("oda isimi" , oda_ayarlari); // oda oluşturmaya yarar.
        PhotonNetwork.JoinOrCreateRoom("oda isimi", oda_ayarlari, TypedLobby.Default);
        PhotonNetwork.LeaveRoom() // odadan çık
        PhotonNetwork.LeaveLobby() // lobiden çık*/


    }

    public override void OnConnectedToMaster()// sunucuya baglaninca calisan fonksiyon
    {
        Debug.Log("Sunucuya Bağlanıldı");
       
    }
    public override void OnJoinedLobby()// lobiye baglanininca calisan fonksiyon  
    {
        Debug.Log("Lobiye Bağlanıldı");
       
    }
    public override void OnJoinedRoom() // odaya baglandi 
    {
        Debug.Log("Odaya Bağlanıldı");

    }
    public override void OnLeftRoom()// odadaan cikildi
    {
        Debug.Log("Lobiye çıkıldı");

    }
    public override void OnLeftLobby()// lobiden cikildi 
    {
        Debug.Log("Lobiye çıkıldı");

    }
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        // herhangi bir oyuncu girdiğinde tetiklenen fonksiyondur.
    }


    public override void OnJoinRoomFailed(short returnCode, string message)// odaya giremiyorsak ve hata varsa calisir
    {
        Debug.Log("Herhangi bir odaya girilemedi");

    }
    public override void OnJoinRandomFailed(short returnCode, string message)// random odaya giremiyorsak ve hata varsa calisir
    {
        Debug.Log("Rastgele bir odaya girilemedi");

    }
    public override void OnCreateRoomFailed(short returnCode, string message)// oda olustururken  ve hata varsa calisir
    {
        Debug.Log("Oda oluşturulamadı");

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
