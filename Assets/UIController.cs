using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class UIController : NetworkManager
{
    [SerializeField] private Button buttonStartServer;
    [SerializeField] private Button buttonStartClient;
    [SerializeField] private Button buttonStartHost;

    bool isServerRun;
    private bool isClientRun;
    private bool isHostRun;

    void Start()
    {
        buttonStartServer.onClick.AddListener(() => StartServerButton());
        buttonStartClient.onClick.AddListener(() => StartClientButton());
        buttonStartHost.onClick.AddListener(() => StartHostButton());
    }

    private void StartServerButton()
    {
        if (!isServerRun)
        {
            singleton.StartServer();
            buttonStartServer.name = "Stop server";
        }
        else
        {
            singleton.StopServer();
            buttonStartServer.name = "Start server";
        }
        isServerRun = !isServerRun;
    }

    private void StartClientButton()
    {
        if (!isClientRun)
        {
            singleton.StartClient();
            buttonStartClient.name = "Stop Client";
        }
        else
        {
            singleton.StopClient();
            buttonStartClient.name = "Start Client";
        }
        isClientRun = !isClientRun;
    }

    private void StartHostButton()
    {
        if (!isHostRun)
        {
            singleton.StartHost();
            buttonStartHost.name = "Stop Host";
        }
        else
        {
            singleton.StopHost();
            buttonStartHost.name = "Start Host";
        }
        isHostRun = !isHostRun;
    }
}
