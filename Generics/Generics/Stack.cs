using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Stack<T,X>
    {

        T[] arr;
        int top;
        public Stack() {
            arr = new T[50];
        }
        public void Push(T a) {
            arr[top++] = a;
        }
        public T Top() {
            return arr[top - 1];        
        }
        public void Pop() {
            top--;
        }
        public void ShowStack() {
            for (int i = 0; i < top; i++) {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
