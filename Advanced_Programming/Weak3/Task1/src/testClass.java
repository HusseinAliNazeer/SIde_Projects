import java.util.Scanner;
interface testInterface{
    final int a=100;
    default void show(String name)
    {
        System.out.println("My name is "+name);
    }

    static int square(int a)
    {
        return a*a;
    }

}

public class testClass implements testInterface {

    public static void main(String[] args) {
	// test default method
        testClass ob=new testClass();
        ob.show("Esraa");
        //test static method
        System.out.println(testInterface.square(5));
    }
}
