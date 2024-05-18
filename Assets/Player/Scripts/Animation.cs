using UnityEngine;
using PlayerSpace;

namespace AnimationControl
{
    public class AnimationController : MonoBehaviour
    {
        private Animator _animator;
        private Player _player;
        
        // Start is called before the first frame update
        void Start()
        {
            _player = GetComponent<PlayerSpace.Player>();
            _animator = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update() 
        {
            Debug.Log("is moving" + _player.IsMoving);
            Debug.Log("isGrounded" + _player._isGrounded);
            Debug.Log("velocityY" + _player._rb.velocity.y);
            
            _animator.SetBool("isMove", _player.IsMoving);
            _animator.SetBool("isGrounded", _player._isGrounded);
            _animator.SetFloat("velocityY", _player._rb.velocity.y);
        }
    }
}