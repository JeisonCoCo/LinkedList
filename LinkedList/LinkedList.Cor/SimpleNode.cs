namespace LinkedList.Cor;

public class SimpleNode<T>
{    
    public SimpleNode(T data) 
    {
        Data = data;
        Next = null;
    }
    //Constructor and properties
    public T? Data { get; set; }
    public SimpleNode<T>? Next { get; set; }//Pointer
}
