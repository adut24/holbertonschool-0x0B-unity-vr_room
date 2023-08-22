using UnityEngine;

public class ProjectorManager : MonoBehaviour
{
    public void ToggleProjector(GameObject projector) => projector.SetActive(!projector.activeSelf);
}
