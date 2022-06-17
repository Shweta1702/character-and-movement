 if (Input.GetButtonDown("Dash"))
        {
            Debug.Log("Dash");
            _velocity += Vector3.Scale(transform.forward, 
                                       DashDistance * new Vector3((Mathf.Log(1f / (Time.deltaTime * Drag.x + 1)) / -Time.deltaTime), 
                                                                  0, 
                                                                  (Mathf.Log(1f / (Time.deltaTime * Drag.z + 1)) / -Time.deltaTime)));
        }
        _velocity.x /= 1 + Drag.x * Time.deltaTime;
_velocity.y /= 1 + Drag.y * Time.deltaTime;
_velocity.z /= 1 + Drag.z * Time.deltaTime;
