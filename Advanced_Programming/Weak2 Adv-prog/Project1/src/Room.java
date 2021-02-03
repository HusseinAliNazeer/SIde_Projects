abstract class Room {
    //An integer variable roomNumber , a boolean variable reserved representing whether the room is
    //reserved or not.
    int roomNumber;
    boolean reserved;
    //constructor that receives the roomNumber for initialization of the roomNumber instance variable
    public Room (int rNum)
    {
        roomNumber=rNum;
    }
    public Room () {}

    @Override
    public String toString() {
        String s="Room No."+roomNumber+"    Reserved "+reserved;
        return s;
    }

    public void setReserved(boolean reserved) {
        this.reserved = reserved;
    }

    public abstract double getPrice();
}
