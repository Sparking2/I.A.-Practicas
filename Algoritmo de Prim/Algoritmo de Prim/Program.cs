using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmo_de_Prim
{
    static class Program
    {
        
        class Archivo
        {
            int total;
            private int[,] datos;
            public List<String> vector;
            public List<String> N;
            public String R;
            private String[,] Adyacencias;
            int numeroAristas = 0;
            public Archivo()
            {
                //nodos
                vector = new List<string>();
                for (int i = 0; i < 188; i++)
                {
                    vector.Add(Convert.ToString(i));
                }
                N = new List<string>();
                R = "";
                Adyacencias = new String[2800, 2];
                datos = new int[188, 188];
            }

            public void lectura()
            {
                OpenFileDialog dialogoArchivo = new OpenFileDialog();
                dialogoArchivo.Filter = "archivos csv (*.csv)|*.csv|Todos los archivos (*.*)|*.*";
                dialogoArchivo.FilterIndex = 1;
                dialogoArchivo.RestoreDirectory = true;


                if (dialogoArchivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.IO.StreamReader lector = new System.IO.StreamReader(dialogoArchivo.FileName);
                    try
                    {

                        int x = 0;
                        int y = 0;

                        String line = null;

                        while (!lector.EndOfStream)
                        {

                            line = lector.ReadLine();

                            string elemento = "";

                            for (int i = 0; i <= line.Length; i++)
                            {
                                if (i != line.Length)
                                {
                                    if (line[i] == ',')
                                    {
                                        if (elemento == "")
                                            elemento = "-1";

                                        datos[x, y] = Int32.Parse(elemento);
                                        elemento = "";
                                        y++;
                                    }
                                    else
                                    {
                                        elemento += line[i];
                                    }
                                }
                                else
                                {
                                    if (elemento == "")
                                        elemento = "-1";
                                    datos[x, y] = Convert.ToInt32(elemento);
                                }
                            }
                            x++;
                            y = 0;
                        }
                        MessageBox.Show("El archivo se a leido correctamente", "Arbol minimo Prim v1", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ea)
                    {
                        MessageBox.Show(Convert.ToString(ea));

                    }
                    lector.Close();
                    algoritmo();
                }
                
            }

            private void algoritmo()
            {
                adyacencias_iniciar();
                N.Add(vector[0]);

                while(comparacion())
                {
                    int posArista = pesoMinimo();
                    R += "(" + Adyacencias[posArista, 0] + "-" + Adyacencias[posArista, 1] + "),";
                    N.Add(Adyacencias[posArista, 1]);
                    numeroAristas++;
                    

                }
            }
            void adyacencias_iniciar()
            {
                int posAdy = 0;
                for (int x = 0; x < 188; x++)
                {
                    for (int y = 0; y < 188; y++)
                    {
                        if (datos[x, y] != -1 && datos[x, y] != 0)
                        {
                            Adyacencias[posAdy, 0] = Convert.ToString(x);
                            Adyacencias[posAdy, 1] = Convert.ToString(y);
                            posAdy++;
                        }
                    }
                }
            }
            bool comparacion()
            {
                bool igual = false;
                if (vector.Count != N.Count)
                    igual = true;
                return igual;
            }
            int pesoMinimo()
            {
                int minimo = int.MaxValue;
                int posArista = 0;
                for (int i = 0; i < N.Count; i++)
                {
                    for (int pos = 0; pos < Adyacencias.GetLength(0); pos++)
                    {
                        if (N[i] == Adyacencias[pos, 0] && !N.Exists(e => e.Equals(Adyacencias[pos, 1])))
                        {
                            int x = Convert.ToInt32(Adyacencias[pos, 0]);
                            int y = Convert.ToInt32(Adyacencias[pos, 1]);
                            if (minimo > datos[x, y])
                            {
                                minimo = datos[x, y];
                                posArista = pos;
                                
                            }
                        }
                    }
                }
                if (minimo == int.MaxValue)
                    minimo = 0;
                total += minimo;
                return posArista;
            }
            public void imprimir()
            {
                String n = "";
                for (int i = 0; i < N.Count; i++)
                    n += N[i] + ", ";
                MessageBox.Show("Procesando datos", "Arbol minimo Prim v1", MessageBoxButtons.OK, MessageBoxIcon.Question);

                FileStream file = new FileStream("Arbol minimo.txt", FileMode.Create, FileAccess.Write);
                try
                {
                    using (StreamWriter wr = new StreamWriter(file))
                    {
                        wr.WriteLine("Vuelos");
                        wr.WriteLine("");
                        wr.WriteLine("N:={" + n + "}");
                        wr.WriteLine("");
                        wr.WriteLine("R:={" + R + "}");
                        wr.WriteLine("");
                        wr.WriteLine("Numero de aristas: {0}", numeroAristas);
                        wr.WriteLine("");
                        wr.WriteLine("Peso total: " + total + " Km");
                        

                        wr.Close();
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                file.Close();
            }

            /// <summary>
            /// Punto de entrada principal para la aplicación.
            /// </summary>
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                MessageBox.Show("Elige el archivo .csv que contiene la matriz", "Arbol minimo Prim v1", MessageBoxButtons.OK, MessageBoxIcon.Question);
                Archivo objarchivo = new Archivo();
                objarchivo.lectura();
                objarchivo.imprimir();
                Application.Run(new Form1());
                               

            }
        }
    }
}
