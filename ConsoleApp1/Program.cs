// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Numerics;
using System.Security.Claims;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Hello, World!");






ListNode<int> main_l1;
ListNode<int> main_l1cop2= new ListNode<int>();
ListNode<int> main_l1cop1=new ListNode<int>(0);
Console.WriteLine(main_l1cop2.Value.Equals(main_l1cop1.Value));

ListNode<int> main_l2;
ListNode<int> main_l3=new ListNode<int>();


main_l1 = new ListNode<int>();//(5, new ListNode<int>(4, new ListNode<int>(3)));
main_l2= new ListNode<int>(5, new ListNode<int>(6, new ListNode<int>(4)));

ListNode<int> main_2 = new ListNode<int>();
ListNode<int> main_3 = new ListNode<int>();

Console.WriteLine(main_l1.ToString());
Console.WriteLine(main_l1.Value.Equals(0));
Console.WriteLine(new ListNode<int>(0, new ListNode<int>(0)).ToString());
Console.WriteLine(new ListNode<int>(0, new ListNode<int>(0)).Next.ToString());
Console.WriteLine(ListNode<int>.connect(main_2, main_3).ToString());
Console.WriteLine(ListNode<int>.connect(main_2, main_3).Next.ToString());
Console.WriteLine(ListNode<int>.connect(main_2, main_3).Equals(ListNode<int>.connect(main_2, main_3)));
//main_l3= ListNode<int>.connect(main_l1,main_l2);
Console.WriteLine(new ListNode<int>(0, new ListNode<int>(0)).
    Equals(ListNode<int>.connect(main_2, main_3)) 
    ? "PASS" : "FAIL");

//main_l3 = ListNode<int>.replace(main_l1,99,4);
while (main_l3.Next != null)
{
    Console.WriteLine(main_l3.Value);
    main_l3 = main_l3.Next;
    //if (main_l3.Value == null) break;
}

Console.WriteLine(main_l3.Value);







//Console.WriteLine(main_l3.ToString());
//Console.WriteLine(main_l3.Next==null);

class ListNode<T>
{
    public readonly T Value;
    public readonly ListNode<T> Next;

    public ListNode() {}
    public ListNode(T val) { this.Value = val; }
    public ListNode(ListNode<T> node) { this.Value = node.Value; this.Next = node.Next;}
    public ListNode(T val, ListNode<T> next) { this.Value = val; this.Next = next; }

    public String ToString()
    {
        return "ListNode{" +
                "val=" + Value +
                ", next=" + Next +
                '}';
    }
    public static ListNode<T> connect(ListNode<T> list1, ListNode<T> list2)
    { if (list1.Value == null) { return list2; }
     if (list2.Value == null) { return list1; }
        ListNode<T> ret_list=new ListNode<T>();
     if (list2 == null&& list1 == null) { return ret_list; }
        if (list1.Next != null)
        {
            ret_list = new ListNode<T>(list1.Value, connect(list1.Next, list2));
        }else {
            return ret_list=new ListNode<T>(list1.Value,list2);
        }
        return ret_list;
}
    public static ListNode<T> replace(ListNode<T> list1,T val, int pos)
    {
        bool gate=false;
        if (pos<=-1) { Console.WriteLine("Число должно быть больше или равно нулю"); return list1; }

        ListNode<T> ret_list = new ListNode<T>() ;
        if (pos == 0)
        {
            return ret_list = new ListNode<T>(val, list1.Next);
        }
        else {
            if (pos > 0 && list1.Next == null)
            {
                Console.WriteLine("Ошибка выхода за границы массива");
                gate = true;
            }
            else { ret_list = new ListNode<T>(list1.Value, replace(list1.Next, val, pos - 1)); }

        } if (gate) return list1;
        return ret_list;
    }

}
