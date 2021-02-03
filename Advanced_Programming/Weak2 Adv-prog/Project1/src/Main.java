public class Main {

    public static void main(String[] args) {
	// write your code here
        Room [] rooms =new Room[6];
        int j=0;
        for(int i=305;i<308;i++)
        {
            rooms[j]=new SingleRoom(i);
            j++;
        }
        for(int i=405;i<408;i++)
        {
            rooms[j]=new DoubleRoom(i);
            j++;
        }
        Hotel myHotel=new Hotel("Fantasy",rooms);
        myHotel.reserveRoom(rooms[1],5);
        myHotel.reserveRoom(rooms[4],3);
        System.out.println("Hotel Income = "+myHotel.income);
        System.out.println(myHotel.toString());


    }
}
