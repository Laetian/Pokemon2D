using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerController : MonoBehaviour
{
    private bool isMoving;
    [SerializeField]
    private float speed;
    private Vector2 input;

    private Animator _animator;

    public LayerMask solidObjectsLayer, pokemonLayer;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(!isMoving)
        {
            input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            //input.x = Input.GetAxisRaw("Horizontal");
            //input.y = Input.GetAxisRaw("Vertical");
            if (input.x !=0)
            {
                input.y = 0;
            }
            if(input != Vector2.zero)
            {
                _animator.SetFloat("MoveX", input.x);
                _animator.SetFloat("MoveY", input.y);
                var targetPosition = transform.position;
                targetPosition.x += input.x;
                targetPosition.y += input.y;

                if (IsAvailable(targetPosition))
                {
                    StartCoroutine(MoveTowards(targetPosition));
                }
            }
        }
    }

    private void LateUpdate()
    {
        _animator.SetBool("is Moving", isMoving);
    }


    IEnumerator MoveTowards(Vector3 destination)
    {
        isMoving = true;
        while(Vector3.Distance(transform.position, destination) > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
            yield return null;
        }
        transform.position = destination;
        isMoving = false;

        CheckForPokemon();
    }

    /// <summary>
    /// The method checks if the next place is available for moving
    /// </summary>
    /// <param name="target">Location to check</param>
    /// <returns>Returns true if it is available or flase if not</returns>
    private bool IsAvailable(Vector3 target)
    {
        if(Physics2D.OverlapCircle(target, 0.30f, solidObjectsLayer)!=null)
        {
            return false;
        }
        return true;
    }

    private void CheckForPokemon()
    {
        if(Physics2D.OverlapCircle(transform.position, 0.2f, pokemonLayer)!=null)
        {
            if (Random.Range(0, 100)<10)
            {
                Debug.Log("Start pokemon bnattle");
            }
        }
    }
}
