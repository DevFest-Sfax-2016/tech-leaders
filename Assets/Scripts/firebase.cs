/*
using UnityEngine;
using System.Collections;

public class firebase : MonoBehaviour {

    // Use this for initialization
    void Start() {
      
    }
    Firebase.Auth.FirebaseAuth auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
    Firebase.Auth.Credential credential =
    auth.FacebookAuthProvider.GetCredential(access_token);
    auth.SignInWithCredentialAsync(credential).ContinueWith(task => {
        if (task.IsComplete && !task.IsCanceled && !task.IsFaulted)
        {
            // User is now signed in.
            Firebase.Auth.FirebaseUser newUser = result.Result();
        }
    }

    Firebase.Auth.FirebaseUser user = auth.CurrentUser;
if (user != null) {
  string name = user.DisplayName;
    string email = user.Email;
    System.Uri photoUrl = user.PhotoUrl;
    // The user's ID, unique to the Firebase project.
    // Do NOT use this value to authenticate with your backend server,
    // if you have one. Use User.Token() instead.
    string uid = user.UID;
}

auth->SignOut();

// Update is called once per frame
void Update () {
	
	}
}
*/ 