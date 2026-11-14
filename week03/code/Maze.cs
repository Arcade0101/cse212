public class Maze
{
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap)
    {
        _mazeMap = mazeMap;
    }

    public void MoveLeft()
    {
        // Check if movement left is allowed (index 0)
        var curr = (_currX, _currY);
        if (_mazeMap.ContainsKey(curr) && _mazeMap[curr][0])
        {
            _currX -= 1;
        }
        else
        {
            throw new InvalidOperationException("Can't go that way!");
        }
    }

    public void MoveRight()
    {
        // Check if movement right is allowed (index 1)
        var curr = (_currX, _currY);
        if (_mazeMap.ContainsKey(curr) && _mazeMap[curr][1])
        {
            _currX += 1;
        }
        else
        {
            throw new InvalidOperationException("Can't go that way!");
        }
    }

    public void MoveUp()
    {
        // Check if movement up is allowed (index 2)
        var curr = (_currX, _currY);
        if (_mazeMap.ContainsKey(curr) && _mazeMap[curr][2])
        {
            _currY -= 1;
        }
        else
        {
            throw new InvalidOperationException("Can't go that way!");
        }
    }

    public void MoveDown()
    {
        // Check if movement down is allowed (index 3)
        var curr = (_currX, _currY);
        if (_mazeMap.ContainsKey(curr) && _mazeMap[curr][3])
        {
            _currY += 1;
        }
        else
        {
            throw new InvalidOperationException("Can't go that way!");
        }
    }

    public string GetStatus()
    {
        return $"Current location (x={_currX}, y={_currY})";
    }
}
