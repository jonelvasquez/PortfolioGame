using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.AI;

public class boatController : MonoBehaviour
{
    CustomActions input;
    NavMeshAgent agent;

    [SerializeField] ParticleSystem clickEffect;
    [SerializeField] LayerMask clickableLayers;

    float lookRotationSpeed = 8f;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();

        input = new CustomActions();
        AssignInputs();
    }

    void AssignInputs()
    {
        input.Main.Move.performed += ctx => ClickToMove();
    }

    void ClickToMove()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 500, clickableLayers))
        {
            // Establecer la nueva posición de destino del agente
            agent.destination = hit.point;

            // Efecto de clic
            if (clickEffect != null)
            {
                Instantiate(clickEffect, hit.point + new Vector3(0, 0.1f, 0), clickEffect.transform.rotation);
            }
        }
    }

    void Update()
    {
        // Si el agente está en movimiento
        if (agent.velocity.sqrMagnitude > 0.1f)
        {
            // Obtener la dirección hacia donde se mueve el agente
            Vector3 directionToFace = agent.velocity;
            directionToFace.y = 0; // Asegurarse de que no afecte la rotación en el eje vertical

            // Calcular la rotación que se debe aplicar
            Quaternion targetRotation = Quaternion.LookRotation(directionToFace);

            // Restar 90 grados en el eje Y para ajustarlo a la orientación deseada
            targetRotation *= Quaternion.Euler(0, -90, 0);

            // Aplicar la rotación suavemente
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, lookRotationSpeed * Time.deltaTime);
        }
    }

    void OnEnable()
    {
        input.Enable();
    }

    void OnDisable()
    {
        input.Disable();
    }
}
