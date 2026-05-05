using UnityEngine;

public class LegPlacer : MonoBehaviour
{
    public GameObject PegLegPrefab;
    public Transform ProjectileSpawnPoint;
    
    public void PlaceLeg(Vector2 position)
    {
        // create leg at peg
        GameObject projectileObject = Instantiate(PegLegPrefab, position, Quaternion.identity);
        
        // start the ball moving forward
        //LaunchProjectile(projectileObject, aimDirection);
    }

    /*
    private void LaunchProjectile(GameObject projectileObject, Vector2 aimDirection)
    { 
        Rigidbody2D projectileRigidbody = projectileObject.GetComponent<Rigidbody2D>();
      
        // add force to the object in the direction
        projectileRigidbody.AddForce(aimDirection * 20f, ForceMode2D.Impulse);
    }
    */
}