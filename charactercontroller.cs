public class Character : MonoBehaviour
{ 
private CharacterController _controller;

void Start()
    {
        _controller = GetComponent<CharacterController>();
    }
    
void Update()
    {
    Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    _controller.Move(move * Time.deltaTime * Speed);
    }
    
}
