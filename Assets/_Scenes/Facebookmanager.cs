using UnityEngine;
using System.Collections;
using Facebook.Unity;
using UnityEngine.UI;
public class Facebookmanager : MonoBehaviour {

    public Text UserIdText;
    private void Awake()
    {
        
            if(!FB.IsInitialized)
            {
                FB.Init();

            }
            else
            {
                FB.ActivateApp();
                
            }

        }
    public void Login()
    {
        FB.LogInWithReadPermissions(callback: OnLogin);
    }
    private void OnLogin (ILoginResult result)
    {
        if(FB.IsLoggedIn)
        {
            AccessToken Token = AccessToken.CurrentAccessToken;
            UserIdText.text = Token.UserId;
        }
        else
        {
            Debug.Log("Canceled Login");
        }
    }
}
