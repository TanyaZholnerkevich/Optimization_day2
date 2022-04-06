using System;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ProjectileBehaviour : MonoBehaviour
{
	[Header("Movement")]
	public float speed = 50f;

	private IEnumerator Start()
	{
		yield return new WaitForSeconds(3f);
		RemoveProjectile();
	}

	void Update()
	{
		Vector3 movement = transform.forward * speed * Time.deltaTime;
		GetComponent<Rigidbody>().MovePosition(transform.position + movement);
	}

	void OnTriggerEnter(Collider theCollider)
	{
		if (theCollider.tag == "Enemy")
			RemoveProjectile();
	}

	void RemoveProjectile()
	{
		gameObject.SetActive(false);
	}
}
