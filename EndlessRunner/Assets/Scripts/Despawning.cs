using UnityEngine;

public class Despawning : MonoBehaviour
{

    PlatformManager platform;
    //private void OnCollisionStay(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Respawn")
    //    {
    //        //Debug.Log("Collided with : " + collision.gameObject.tag);
            
    //        Destroy(gameObject);

    //        GameObject go = GameObject.Find("PlatformManagerObject");
    //        PlatformManager platform =(PlatformManager) go.GetComponent(typeof(PlatformManager));
    //        platform.PlacePlatform();
    //    }
    //}



	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Platform")
		{
			Debug.Log("IT WORKS!"+gameObject+"  "+ other.gameObject);
			
			Destroy(other.gameObject);

			GameObject go = GameObject.Find("PlatformManagerObject");
			PlatformManager platform = (PlatformManager)go.GetComponent(typeof(PlatformManager));
			platform.PlacePlatform();

		}
	}


}
