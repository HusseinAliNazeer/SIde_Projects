public class DoubleRoom extends Room {

    public DoubleRoom(int rNum)
    {
        super(rNum);
    }
    @Override
    public double getPrice() {
        return 300;
    }
}
