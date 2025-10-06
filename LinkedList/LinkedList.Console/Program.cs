using LinkedList.Cor;

var list = new SinglyLinkedList<string>();
list.InsertAtBeginning("Perro");
list.InsertAtBeginning("Gato");
list.InsertAtBeginning("Cabra");
list.InsertAtBeginning("Vaca");
list.InsertAtEnd("Tigre");
list.InsertAtEnd("Hiena");
list.InsertAtEnd("Ñu");
list.InsertAtEnd("Cocodrilo");

list.PrintList();