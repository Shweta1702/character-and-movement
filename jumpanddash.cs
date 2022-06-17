if (Input.GetButtonDown("Jump") && _isGrounded)
{
_body.AddForce(Vector3.up * Mathf.Sqrt(JumpHeight * -2f * Physics.gravity.y), ForceMode.VelocityChange);
}
if (Input.GetButtonDown("Dash"))
{
Vector3 dashVelocity = Vector3.Scale(transform.forward, DashDistance * new Vector3((Mathf.Log(1f / (Time.deltaTime * _body.drag + 1)) / -Time.deltaTime), 0, (Mathf.Log(1f / (Time.deltaTime * _body.drag + 1)) / -Time.deltaTime)));
_body.AddForce(dashVelocity, ForceMode.VelocityChange);
}
