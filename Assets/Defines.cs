using System;

public enum Direction { left, right, up, down };

public struct IndexPaar {
    public int col;
    public int row;

    public IndexPaar GetNeighbour(Direction dir) {
        IndexPaar neighbour = this;

        switch (dir) {
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

    public Direction GetNeighbourDirection(IndexPaar potentionalNeighbour) {
        if (potentionalNeighbour.col == col) {
            if (potentionalNeighbour.row == row + 1) {
                return Direction.up;
            }
            if (potentionalNeighbour.row == row - 1) {
                return Direction.down;
            }
        }
        if (potentionalNeighbour.row == row) {
            if (potentionalNeighbour.col == col + 1) {
                return Direction.right;
            }
        }
        return Direction.left;
    }
}
