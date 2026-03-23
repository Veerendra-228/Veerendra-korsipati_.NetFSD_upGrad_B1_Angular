using System;
using System.Collections.Generic;

class task4
{
    static void Main()
    {
        Stack<string> undo = new Stack<string>();
        Stack<string> redo = new Stack<string>();

        undo.Push("Type A");
        undo.Push("Type B");
        undo.Push("Delete A");
        undo.Push("Type C");

       
        for (int i = 0; i < 3; i++)
        {
            var action = undo.Pop();
            redo.Push(action);
            Console.WriteLine("Undo: " + action);
        }

        Console.WriteLine("Top: " + undo.Peek());

      
        var redoAction = redo.Pop();
        undo.Push(redoAction);
        Console.WriteLine("Redo: " + redoAction);
    }
}