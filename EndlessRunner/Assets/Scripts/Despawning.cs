
using UnityEngine;

public class Despawning : MonoBehaviour
{
    //private void OnCollisionEnter(Collision collision)
    //{

    //    if (collision.gameObject.tag == "Respawn" )
    //    {
    //        Debug.Log("Collided with : " + collision.gameObject.tag);
    //        Destroy(gameObject);

    //    } 
    //}

    PlatformManager platform;
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Respawn")
        {
            Debug.Log("Collided with : " + collision.gameObject.tag);
            
            Destroy(gameObject);

            GameObject go = GameObject.Find("PlatformManagerObject");
            PlatformManager platform =(PlatformManager) go.GetComponent(typeof(PlatformManager));
            platform.PlacePlatform();

            
           
            
        }
    }
}
