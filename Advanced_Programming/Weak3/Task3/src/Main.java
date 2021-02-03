class A{
    public  void show()
    {
        System.out.println("This is Class A");
    }

    public void show(String name)
    {
        System.out.println("My Name is "+name);
    }
}

class B extends A {
    public void show()
    {
        System.out.println("This is Class B");
    }

    public void show(String name)
    {
        System.out.println("My name is "+ name);
    }
}

public class Main {

    public static void main(String[] args) {
	// write your code here
    A ob1=new A();
    ob1.show();
    ob1.show("Esraa");
    B ob2 =new B();
    ob2.show();
    ob2.show("Fayad");
    }
}
