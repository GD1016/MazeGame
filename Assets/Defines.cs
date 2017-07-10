public enum Direction { left, right, up, down }

public enum RandomWord { Kekse, Kuchen, Bananenshake, Erdbärkäse, Ameisenkatapult, Bienenbär, Schokonudeln, Burger,
    Schokoladenboot, Erdbeerbananen, Bananenelefanten, Elefantenurologe, Urologenquartett, Quartetttisch,
    Tischapfel, Apfelkürbis }

public struct IndexPaar {
    public int col;
    public int row;

    public IndexPaar GetNeighbour(Direction dir) {
        IndexPaar neightbour = this;

        switch (dir) {
            case Direction.left:
                neightbour.col--;
                break;
            case Direction.right:
                neightbour.col++;
                break;
            case Direction.up:
                neightbour.col++;
                break;
            case Direction.down:
                neightbour.col--;
                break;
        }

        return neightbour;
    }
}