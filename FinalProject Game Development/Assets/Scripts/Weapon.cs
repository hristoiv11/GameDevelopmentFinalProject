using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Weapon : MonoBehaviour
{
        public string weaponName;
        public GameObject bulletPrefab;
        public Transform shootingPoint;
        public float fireRate;

        private float nextFireTime = 0f;

        public void Shoot()
        {
            if (Time.time > nextFireTime)
            {
                Instantiate(bulletPrefab, shootingPoint.position, shootingPoint.rotation);
                nextFireTime = Time.time + 1f / fireRate;
            }
        }
    }

