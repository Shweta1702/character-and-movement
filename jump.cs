f (Input.GetButtonDown("Jump") && _isGrounded)
    _velocity.y += Mathf.Sqrt(JumpHeight * -2f * Gravity);
    if (Input.GetButtonDown("Jump") && _isGrounded)
    _velocity.y += JumpForce;
