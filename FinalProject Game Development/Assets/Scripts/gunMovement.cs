using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunMovement : MonoBehaviour
{


    /*
    public GameObject bulletPrefab;
    public Transform bulletSpawn; // We'll use this as the shooting point
    public float bulletSpeed = 10; // Speed at which the bullet moves

    void Update()
    {
        AimGun();
        if (Input.GetKeyDown(KeyCode.Space)) // Use Space key to shoot
        {
            Shoot();
        }
    }

    private void AimGun()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0; // Ensure there is no change in the z-axis

        Vector3 direction = mousePosition - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }

    private void Shoot()
    {
        var bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawn.up * bulletSpeed;
    }
    */

    /*
    
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float bulletSpeed = 10;
    public AudioClip shootSound; // Drag your sound clip here in the inspector
    private AudioSource audioSource; // AudioSource component

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Get the AudioSource component
    }

    void Update()
    {
        AimGun();
        if (Input.GetMouseButtonDown(0)) // Shoot on left click
        {
            Shoot();
        }
    }

    private void AimGun()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0; // Adjust the z-axis for 2D game if necessary

        Vector2 direction = mousePosition - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }

    private void Shoot()
    {
      
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawn.up * bulletSpeed;
        audioSource.PlayOneShot(shootSound);
    }
    */

    /*
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float bulletSpeed = 10f;
    public AudioClip shootSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        AimGun();
        if (Input.GetMouseButtonDown(0)) // Left mouse button to shoot
        {
            Shoot();
        }
    }

    void AimGun()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0; // Adjust the z-axis for 2D

        Vector2 direction = mousePosition - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawn.right * bulletSpeed; // Adjust direction if needed
        audioSource.PlayOneShot(shootSound);
    }
    */

    public GameObject bulletPrefab;
    public Transform bulletSpawn; // The actual object at the tip of the gun
    public float bulletSpeed = 10f;
    public float fireRate = 0.2f; // Time between shots
    public AudioClip shootSound;
    private AudioSource audioSource;
    private float nextFireTime = 0f; // Time when the next shot can be fired

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        AimGun();
        if (Input.GetMouseButton(0) && Time.time > nextFireTime) // Continuous shooting with left mouse button
        {
            Shoot();
            nextFireTime = Time.time + fireRate;
        }
    }

    void AimGun()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0; // Adjust the z-axis for 2D

        Vector2 direction = mousePosition - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }

    void Shoot()
    {
        // Instantiate bullet at bulletSpawn's position and rotation
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

        // Ensure the bullet has a Rigidbody2D component
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = bulletSpawn.right * bulletSpeed; // Adjust if needed
        }
        else
        {
            Debug.LogError("No Rigidbody2D component found on bullet prefab!");
        }

        audioSource.PlayOneShot(shootSound);

        Debug.Log("Bullet instantiated at position: " + bulletSpawn.position);
        Debug.Log("Bullet velocity: " + rb.velocity);
    }

}
