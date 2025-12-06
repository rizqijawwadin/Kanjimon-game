using UnityEngine;
using UnityEngine.InputSystem;

public class MenuController : MonoBehaviour
{
  public GameObject mainMenu;
  
  void Update()
  {
    if (Keyboard.current.escapeKey.wasPressedThisFrame)
    {
      mainMenu.SetActive(!mainMenu.activeSelf);
    }
  }

  public void CloseMenu()
  {
    mainMenu.SetActive(false);
  }
}
