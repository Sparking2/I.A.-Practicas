using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmo_Dijkstra
{
    class Dijkstra
    { //variables a usar
        private int rango = 0;
        private int[,] L; //Matriz de adyacencia
        private int[] C; //Arreglo de Nodos
        private int[] D; //Arreglo de Distancias
        private int trango = 0;
        
        
        //Algoritmo Dijkstra
        public Dijkstra(int paramRango, int[,]paramArreglo)
        {
            L = new int[paramRango, paramRango];
            C = new int[paramRango];
            D = new int[paramRango];
            rango = paramRango;
            //llenamos la matris L con los datos que trabajaremos
            for (int i=0;i<rango;i++)
            {
                for (int j = 0;j<rango;j++)
                {
                    L[i, j] = paramArreglo[i, j];
                }
            }
            for (int i = 1;i<rango;i++)
            {
                C[i] = i;
            }
            //Evaluamos la distancia de los nodos adyacentes
            C[0] = -1;
            //rango = nodo destino...
            for (int i = 1; i < rango; i++)
                D[i] = L[0, i];
        }

        //Rutina de solución Dijkstra
        public void SolDijkstra()
        {
            int minValor = Int32.MaxValue;
            int minNodo = 0;

            for(int i = 0;i<rango;i++)
            {
                if (C[i] == -1)
                    continue;
                if (D[i] > 0 && D[i] < minValor)
                {
                    minValor = D[i];
                    minNodo = i;
                }
            }
            C[minNodo] = -1;
            for (int i = 0; i<rango;i++)
            {
                if (L[minNodo, i] < 0)   //si no existe arco
                    continue;
                if (D[i]<0)             //si no hay peso asignado
                {
                    D[i] = minValor + L[minNodo, i];
                    continue;
                }
                if ((D[minNodo] + L[minNodo, i]) < D[i])
                    D[i] = minValor + L[minNodo, i];
            }
        }

        //Función de implementación del algoritmo
        public void CorrerDijkstra()
        {
            for (trango = 1; trango<rango;trango++)
            {
                SolDijkstra();
                Console.WriteLine("Iteracion No. " + trango);
                Console.WriteLine("Matriz de distancias: ");

                for (int i = 0; i < rango; i++)
                    Console.WriteLine(i + " ");

                Console.WriteLine(" ");

                for (int i = 0; i < rango; i++)
                    Console.Write(D[i] + " ");

                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }
        }
        static void Main(string[] args)
        {
            //Definicion de la matriz de Adyacencia
            int[,] L = {
                          {-1,10,18,-1,-1,-1,-1},
                          {-1,-1,  6,-1,3,-1,-1},
                          {-1,-1,-1, 3,-1,20,-1},
                          {-1,-1, 2,-1,-1,-1, 2},
                          {-1,-1,-1, 6,-1,-1,10},
                          {-1,-1,-1,-1,-1,-1,-1},
                          {-1,-1,10,-1,-1, 5,-1}
                      };
            Dijkstra prueba = new Dijkstra((int)Math.Sqrt(L.Length),L);
            prueba.CorrerDijkstra();

            Console.WriteLine("La solucion de la ruta mas corta tomando como nodo inicial el Nodo 1 es: ");

            /*
             //Versión solo el nodo buscado
             
             int user_input = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int nodo = 1;
            foreach(int i in prueba.D)
            {
                if (nodo == user_input)
                {
                    Console.Write("Distancia minima a nodo " + nodo + " es ");
                    Console.WriteLine(i);

                }
                nodo++;
            }*/

            int nodo = 1;
            foreach(int i in prueba.D)
            { 
                    Console.Write("Distancia minima a nodo " + nodo + " es ");
                    Console.WriteLine(i);
                    nodo++;
            }
            
            
            Console.WriteLine();
            Console.WriteLine("Presiona e para Salir.");
            Console.ReadKey();
        }
    }
}
