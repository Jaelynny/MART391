using UnityEngine;
using UnityEngine.Services;
using UnityEngine.Services.Authentication;

public class AuthManager : MonoBehaviour
{
    async void Start()
    {
        await UnityServices.InitializeAsync();
    }

    public async Task SignInWithAuth0Async()
    {
        var result = await AuthenticationService.Instance.SignInWithPlatformAsync("auth0");
        if (result.IsSuccess)
        {
            Debug.Log("Signed in with Auth0: " + result.PlayerId);
        }
        else
        {
            Debug.LogError("Sign in failed: " + result.Error);
        }
    }
}

