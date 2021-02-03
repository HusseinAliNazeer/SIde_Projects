public class Hotel {
    String name;
    double income;
    Room [] rooms;
    int countRooms=0;
    public Hotel(String n ,Room [] rooms )
    {
        name=n;
        this.rooms=rooms;
    }

    public double getIncome() {
        return income;
    }

    public String getName() {
        return name;
    }

    public Room[] getRooms() {
        return rooms;
    }

    public boolean reserveRoom(Room room,int days)
    {
        if(!room.reserved){
            room.reserved=true;
            for (int i=0;i<days;i++)
                income+=room.getPrice();
            countRooms++;
            return true;
        }
        else
            return false;
    }

    public boolean isFull()
    {
        if(countRooms==rooms.length)
            return true;
        else
            return false;
    }

    @Override
    public String toString() {
        int emptyRooms=rooms.length-countRooms;
        String s="Hotel Name : "+name+"\tNumber of Rooms = "+rooms.length+"\tNumber of Empty Rooms = "+emptyRooms;
        return s;
    }
}
