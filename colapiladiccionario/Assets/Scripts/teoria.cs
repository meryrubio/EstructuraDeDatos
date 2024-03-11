using System.Collections;
using System.Collections.Generic;
using UnityEditor.Compilation;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class teoria : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //EJERCICIO PILA
        //Crea una pila e introduce en ella estos números en el siguiente orden: 4, -5, -10, 88, 2
        Stack<int> stack = new Stack<int>();
        stack.Push(4);
        stack.Push(-5);
        stack.Push(-10);
        stack.Push(88);
        stack.Push(2);

        //Consigue que, usando solo pilas y una variable auxiliar como máximo, la pila original tenga los números apilados de menor a mayor.

        Stack<int> stack1 = new Stack<int>(); // segunda pila

        while (stack.Count > 0) //( stack.count = devuelve el número de elementos actualmente en la pila) mientras que la pila original no este vacía: 
        {
            int aux = stack.Pop(); // creamos una variable aux que se asigna al elemnto que sale

            while (stack1.Count > 0 && stack1.Peek() > aux)  // (stack.peek =  elemento en la parte superior de la pila sin eliminarlo de la pila) 
                                                             //mientras que la segunda pila no este vacia y el ultimo elemento de ella sea mayor que el aux(el que salio)
            {
                stack.Push(stack1.Pop()); // añadimos el elemento que sale de la segunda pila a la original.
            }
            stack1.Push(aux); // añadimos a la segunda pila el que sale de la primera
        }

        while (stack1.Count > 0) // mientras que la segunda pila no est vacia se añade a l a original el que sale de la segunda
        {
            stack.Push(stack1.Pop());
        }

        while(stack.Count > 0) // imprimimos la original.
        {
            Debug.Log(stack.Pop());
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
