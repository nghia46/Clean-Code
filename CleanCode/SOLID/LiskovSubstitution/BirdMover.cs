namespace CleanCode.SOLID.LiskovSubstitution;

public class BirdMover
{
    public void MakeBirdMove(IBird bird)
    {
        bird.Move();
    }
}