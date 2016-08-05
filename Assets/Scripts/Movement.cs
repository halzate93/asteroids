﻿using UnityEngine;

namespace Asteroids
{
    public class Movement : MonoBehaviour
    {
        [SerializeField]
        private float speed;

        private void Update()
        {
            float movement = Input.GetAxis("Vertical");
			transform.Translate(Vector3.forward * speed * movement * Time.deltaTime);
        }
    }
}