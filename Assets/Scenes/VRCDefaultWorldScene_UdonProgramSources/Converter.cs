using UdonSharp;
using UnityEngine;
using VRC.SDK3.StringLoading;
using VRC.SDKBase;
using VRC.Udon;

public class Converter : UdonSharpBehaviour
{
    public VRCUrl vrcUrl; // This will hold the converted URL

    // Public method to set the VRCUrl
    public void SetUrl(string urlString)
    {
        // Set the VRCUrl property (this must be done through the Inspector)
        // vrcUrl must be set in the Unity Inspector, not in the code directly.
    }
}
