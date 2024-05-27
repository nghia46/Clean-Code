using CleanCode.SOLID.LiskovSubstitution;

namespace CleanCode.Client.SOLID;
public class LiskovSubstitutionClient {
    public void Main()
    {
        BirdMover birdMover = new BirdMover();

        IBird chicken = new Chicken();
        IBird sparrow = new Sparrow();

        birdMover.MakeBirdMove(chicken);
        birdMover.MakeBirdMove(sparrow);
    }
}