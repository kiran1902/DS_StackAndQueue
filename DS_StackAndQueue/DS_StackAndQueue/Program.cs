using DS_StackAndQueue;

Console.WriteLine("Welcome to Stack And Queue");

/// <summary>
 /// UC4 - To Delete Element from the Queue
 /// </summary

MyQueue<int> myQueue = new MyQueue<int>();
myQueue.Enqueue(56);
myQueue.Enqueue(30);
myQueue.Enqueue(70);
myQueue.Show();

Console.WriteLine("Before Deletion");
myQueue.Dequeue();
//myQueue.IsEmpty();
myQueue.Show();