using UnityEngine;

public class ChangeSubjectState : MonoBehaviour
{
    public Subject subject;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            subject.State = "Nuevo Estado: " + Random.Range(1, 100);
        }
    }
}
