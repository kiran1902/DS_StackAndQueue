using DS_StackAndQueue;

Console.WriteLine("Welcome to Stack And Queue");

/// <summary>
 /// UC2 - Create a Peek and Pop method 
 /// </summary

My_Stack<int> my_Stack = new My_Stack<int>();
my_Stack.Push(70);
my_Stack.Push(30);
my_Stack.Push(56);
my_Stack.Show();

my_Stack.Peek();

Console.WriteLine("Befor Pop");
my_Stack.Pop();
my_Stack.IsEmpty();
my_Stack.Show();