using UnityEngine;
namespace Chapter.Command
{
public class InputHandler : MonoBehaviour
{
private Invoker _invoker;
private bool _isReplaying;
private bool _isRecording;
private SpaceShipController _spaceShipController;
private Command _buttonA, _buttonD, _buttonW;
void Start()
{
_invoker = gameObject.AddComponent<Invoker>();
_spaceShipController = FindObjectOfType<SpaceShipController>();
_buttonA = new TurnLeft(_spaceShipController);
_buttonD = new TurnRight(_spaceShipController);
_buttonW = new ToggleTurbo(_spaceShipController);
}
void Update()
{
if (!_isReplaying && _isRecording)
{
if (Input.GetKeyUp(KeyCode.A))
_invoker.ExecuteCommand(_buttonA);
if (Input.GetKeyUp(KeyCode.D))
_invoker.ExecuteCommand(_buttonD);
if (Input.GetKeyUp(KeyCode.W))
_invoker.ExecuteCommand(_buttonW);
} }
void OnGUI()
{
if (GUILayout.Button("Start Playing"))
{
_spaceShipController.ResetPosition();
_isReplaying = false;
_isRecording = true;
_invoker.Record();
}
if (GUILayout.Button("Stop Playing"))
{
_spaceShipController.ResetPosition();
_isRecording = false;
}
if (!_isRecording)
{
if (GUILayout.Button("Start Replay of Game"))
{
_spaceShipController.ResetPosition();
_isRecording = false;
_isReplaying = true;
_invoker.Replay();
}
}
}
}
}

