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

            for (int i=0;i<rango;i++)
            {
                for (int j = 0;j<rango;j++)
                {
                    L[i, j] = paramArreglo[i, j];
                }
            }
            for (int i = 0;i<rango;i++)
            {
                C[i] = i;
            }
            C[0] = -1;
            for (int i = 1; i < rango; i++)
                D[i] = L[0, i];
        }
        static void Main(string[] args)
        {
        }
    }
}
