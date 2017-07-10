public enum Direction {left, right, up, down};

public struct IndexPaar {
    public int col;
    public int row;

    public IndexPaar GetNeighbour(Direction dir)
    {
        IndexPaar neighbour = this;

        switch (dir)
        {
            case Direction.left:
                neighbour.col--;
                break;
            case Direction.right:
                neighbour.col++;
                break;
            case Direction.up:
                neighbour.row++;
                break;
            case Direction.down:
                neighbour.row--;
                break;
        }

        return neighbour;
    }
}