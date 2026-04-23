using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : MonoBehaviour
{
    [Header("Rifle Things")]
    public float giveDamageOf = 10f;
    public float shootingRange = 100f;
    public Camera camera;
    public float fireCharge = 15f;
    public Animator animator;
    public Player player;


    [Header("Rifle Ammunition and shooting")]
    private int maxAmula = 20;
    private int mag = 15;
    private int preAmula;
    public float reloadinhTime = 1.3f;
    private bool setRelaod = false;
    private float nextTimeToShoot = 0f;


    [Header("Rifle Effects")]
    public ParticleSystem muzzelSpark;
    public GameObject impactEffect;

    //[Header("Sounds and UI")]


    private void Awake()
    {
        preAmula = maxAmula;
        muzzelSpark.Stop();
    }



    // Update is called once per frame
    void Update()
    {
        if(setRelaod)
        return;

        if(preAmula <= 0)
        {
            StartCoroutine(Reload());
            return;
        }

        if(Input.GetButton("Fire1") && Time.time >= nextTimeToShoot)
        {
            animator.SetBool("Fire",true);
            animator.SetBool("Idle",false);
            nextTimeToShoot = Time.time + 1f/fireCharge;
            Shoot();
            muzzelSpark.Play();
        }
        else
        {
            animator.SetBool("Fire",false);
            animator.SetBool("Idle",true);
            muzzelSpark.Stop(); 
         //muzzelSpark.Play();
        }
    }


    void Shoot()
    {
        if(mag == 0)
        {
            //show ammo out text
            return;
        }
        preAmula--;
        if(preAmula == 0)
        {
            mag--;
        }
       
        //muzzelSpark.Play();
        RaycastHit hitInfo;

        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hitInfo, shootingRange))
        {
            Debug.Log(hitInfo.transform.name);

            Objects objects = hitInfo.transform.GetComponent<Objects>();

            if(objects != null)
            {
                objects.objectHitDamage(giveDamageOf);
               
            }
            GameObject impactGo = Instantiate(impactEffect,hitInfo.point,Quaternion.LookRotation(hitInfo.normal));
            Destroy(impactGo,5f);
        }
    }

    IEnumerator Reload()
    {
        player.playerSpeed = 0f;
        player.sprint = 0f;
        setRelaod = true;
        Debug.Log("Reload");
        animator.SetBool("Reload",true);
        yield return new WaitForSeconds(reloadinhTime);
        animator.SetBool("Reload",false);
        preAmula = maxAmula;
        player.playerSpeed = 1.9f;
        player.sprint = 3;
        setRelaod=false;
    }
}
