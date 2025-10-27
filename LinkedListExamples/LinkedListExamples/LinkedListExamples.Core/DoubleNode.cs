using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExamples.Core;

public class DoubleNode<T>
{

    public DoubleNode(T data)
    {
        Data = data;
        Prev = null;
        Next = null;
    }

    public T? Data
    {
        get; set;
    }

    public DoubleNode<T>? Prev
    {
        get; set;
    }

    public DoubleNode<T>? Next
    {
        get; set;
    }


}
