public class SingleRoom extends Room {


    public SingleRoom(int rNum)
    {
        super(rNum);
    }

    @Override
    public double getPrice() {
        return 200;
    }
}
