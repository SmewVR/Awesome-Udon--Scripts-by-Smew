
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class proximitycube : UdonSharpBehaviour
{
    public GameObject[] target_list;
    

    public override void OnPlayerTriggerEnter(VRCPlayerApi player)
    {
        if (player == Networking.LocalPlayer)
        {

            for (int i = 0; i < target_list.Length; i++)
            {
                target_list[i].SetActive(true);
            }
        }
    }

    public override void OnPlayerTriggerExit(VRCPlayerApi player)
    {
        if (player == Networking.LocalPlayer)
        {
            for (int i = 0; i < target_list.Length; i++)
            {
                target_list[i].SetActive(false);
            }
        }
    }
}
