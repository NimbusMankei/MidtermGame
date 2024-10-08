namespace Chapter.Command
{
public abstract class Command
{
public abstract void Execute();
}
}

namespace Chapter.Command
{
public class ToggleTurbo : Command
{
private SpaceShipController _controller;
public ToggleTurbo(SpaceShipController controller)
{
_controller = controller;
}
public override void Execute()
{
_controller.ToggleTurbo(); } }}

namespace Chapter.Command
{
public class TurnLeft : Command
{
private SpaceShipController _controller;
public TurnLeft(SpaceShipController controller)
{
_controller = controller;
}
public override void Execute()
{
_controller.Turn(SpaceShipController.Direction.Left);
}
}
}
namespace Chapter.Command
{
public class TurnRight : Command
{
private SpaceShipController _controller;
public TurnRight(SpaceShipController controller)
{
_controller = controller;
}
public override void Execute()
{
_controller.Turn(SpaceShipController.Direction.Right);
}
}
}
