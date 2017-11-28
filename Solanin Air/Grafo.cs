using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solanin_Air
{
    public class Grafo:List<Vertice>
    {
        int cantAristas;
        ListaAristas nodosKruskal;

        public Grafo()
        {
            nodosKruskal = new ListaAristas();
            cantAristas = new int();
        }

        public Grafo(ListaVuelos listaV)
        {
            List<char> listaC = new List<char>();
            nodosKruskal = new ListaAristas();
            cantAristas = new int();
            int x = new int();
            int y = new int();
            for (int i = 0; i < listaV.Count; i++)
            {
                if (!listaC.Contains((listaV[i].getOrigen())))
                {
                    listaC.Add(listaV[i].getOrigen());
                }
                if (!listaC.Contains((listaV[i].getDestino())))
                {
                    listaC.Add(listaV[i].getDestino());
                }
            }
            for (int i = 0; i < listaC.Count; i++)
            {
                ListaAristas listaA = new ListaAristas();
                for (int j = 0; j < listaV.Count; j++)
                {
                    if (listaC[i] == listaV[j].getOrigen())
                    {
                        for(int k = 0; k < this.Count; k++)
                        {
                            if(this[k].getOrigen() == listaV[j].getDestino())
                            {
                                x = this[k].X;
                                y = this[k].Y;
                            }
                        }
                        Arista a = new Arista(listaC[i], listaV[j].getDestino(), listaV[j].getCosto(), x, y);
                        listaA.Add(a);
                        cantAristas++;
                    }
                }

                Vertice v = new Vertice(listaC[i],listaA);
                this.Add(v);
            }
        }

        public Grafo(ListaVuelos listaV, char b)
        {
            List<char> listaC = new List<char>();
            nodosKruskal = new ListaAristas();
            cantAristas = new int();
            int x = new int();
            int y = new int();
            for (int i = 0; i < listaV.Count; i++)
            {
                if (!listaC.Contains((listaV[i].getOrigen())))
                {
                    listaC.Add(listaV[i].getOrigen());
                }
                if (!listaC.Contains((listaV[i].getDestino())))
                {
                    listaC.Add(listaV[i].getDestino());
                }
            }
            for (int i = 0; i < listaC.Count; i++)
            {
                ListaAristas listaA = new ListaAristas();
                for (int j = 0; j < listaV.Count; j++)
                {
                    if (listaC[i] == listaV[j].getOrigen())
                    {
                        for (int k = 0; k < this.Count; k++)
                        {
                            if (this[k].getOrigen() == listaV[j].getDestino())
                            {
                                x = this[k].X;
                                y = this[k].Y;
                            }
                        }
                        Arista a = new Arista(listaC[i], listaV[j].getDestino(), listaV[j].getTiempo(), x, y);
                        listaA.Add(a);
                        cantAristas++;
                    }
                }

                Vertice v = new Vertice(listaC[i], listaA);
                this.Add(v);
            }
        }

        public void guardarVertices()
        {
            System.IO.StreamWriter writer = new System.IO.StreamWriter("Vertices.txt");
            foreach (Vertice vertice in this)
            {
                writer.WriteLine(vertice.ToStringOut());
            }
            writer.Close();
        }

        public void  cargarVertices()
        {
            System.IO.StreamReader reader = new System.IO.StreamReader("Vertices.txt");
            string cad;

            while (!reader.EndOfStream)
            {
                cad = reader.ReadLine();
                foreach(Vertice vertice in this)
                {
                    if(vertice.getOrigen() == cad[0])
                    {
                        vertice.setXYfromFile(cad);                      
                    }
                }
            }

            reader.Close();

            for (int i = 0; i < Count; i++)
            {
                for (int j = 0; j < this[i].getListAristas().Count; j++)
                {
                    this[i].getListAristas()[j].X = buscaNodoX(this[i].getListAristas()[j].getDestino());
                    this[i].getListAristas()[j].Y = buscaNodoY(this[i].getListAristas()[j].getDestino());
                }
            }
        }

        public int buscaNodoX(char destino)
        {
            foreach(Vertice vertice in this)
            {
                if (vertice.getOrigen() == destino)
                    return vertice.X;
            }
            return 0;
        }

        public int buscaNodoY(char destino)
        {
            foreach (Vertice vertice in this)
            {
                if (vertice.getOrigen() == destino)
                    return vertice.Y;
            }
            return 0;
        }

        public Grafo kruskal()
        {
            Grafo prometedor = new Grafo();
            ListaAristas candidatos = new ListaAristas();
            nodosKruskal = new ListaAristas();
            List<string> compConex = new List<string>();

            for (int i = 0; i < this.Count; i++)
            {
                for (int j = 0; j < this[i].getListAristas().Count; j++)
                {
                    candidatos.Add(this[i].getListAristas()[j]);
                }
            }
            for (int i = 0; i < this.Count; i++)
            {
                compConex.Add(Convert.ToString(this[i].getOrigen()));
            }
            quickSort(ref candidatos, 0, candidatos.Count - 1);
            int c1 = new int();
            int c2 = new int();

            for (int contador = 0; prometedor.getListaKruskal().Count < this.Count - 1; contador++)
            {
                Vertice u = new Vertice(candidatos[contador].Origen, buscaNodoX(candidatos[contador].Origen), buscaNodoY(candidatos[contador].Origen));
                Vertice v = new Vertice(candidatos[contador].getDestino(), buscaNodoX(candidatos[contador].getDestino()), buscaNodoY(candidatos[contador].getDestino()));
                //**Seleccion
                Arista a = new Arista(u.getOrigen(), v.getOrigen(), candidatos[contador].Peso, buscaNodoX(v.getOrigen()), buscaNodoY(v.getOrigen()));
                c1 = buscaKruskal(u.getOrigen(), compConex);
                c2 = buscaKruskal(v.getOrigen(), compConex);
                if (c1 != c2)
                {
                    int indicePrometedor = prometedor.contiene(u.getOrigen());
                    if (indicePrometedor != -1)
                    {
                        prometedor[indicePrometedor].getListAristas().Add(a);
                    }
                    else
                    {
                        u.getListAristas().Add(a);
                        prometedor.Add(u);
                    }

                    if (prometedor.contiene(v.getOrigen()) == -1)
                    {
                        prometedor.Add(v);
                    }
                    //Fusion                    
                    compConex[c1] += compConex[c2];
                    compConex.RemoveAt(c2);
                    prometedor.getListaKruskal().Add(a);
                }

            }
            return prometedor;
        }

        private int buscaKruskal(char c, List<string> cc)
        {
            for (int i = 0; i < cc.Count; i++)
            {
                if (cc[i].Contains(c))
                {
                    return i;
                }
            }
            return -1;
        }

        public ListaAristas getListaKruskal()
        {
            return nodosKruskal;
        }

        public Grafo prim()
        {
            string subGrafo = "";
            Grafo prometedor = new Grafo();
            ListaAristas candidatos = new ListaAristas();

            for (int i = 0; i < this.Count; i++)
            {
                for (int j = 0; j < this[i].getListAristas().Count; j++)
                {
                    candidatos.Add(this[i].getListAristas()[j]);
                }
            }
            quickSort(ref candidatos, 0, candidatos.Count - 1);

            subGrafo = candidatos[0].Origen.ToString();
            prometedor.Add(new Vertice(candidatos[0].Origen, buscaNodoX(candidatos[0].Origen), buscaNodoY(candidatos[0].Origen)));
            int numCandidatos = candidatos.Count;
            for(int i = 0; i < numCandidatos && prometedor.Count != this.Count; i++)
            {
                Vertice origen, destino;              
                
                Arista a = seleccion(candidatos, subGrafo);                                
                prometedor.getListaKruskal().Add(a);
                if (subGrafo.Contains(a.Origen))
                {
                    subGrafo += a.getDestino();
                    destino = new Vertice(a.getDestino(), buscaNodoX(a.getDestino()), buscaNodoY(a.getDestino()));
                    prometedor.Add(destino);
                    prometedor[prometedor.contiene(a.Origen)].getListAristas().Add(a);
                }
                else if (subGrafo.Contains(a.getDestino()))
                {
                    subGrafo += a.Origen;
                    origen = new Vertice(a.Origen, buscaNodoX(a.Origen), buscaNodoY(a.Origen));
                    origen.getListAristas().Add(a);
                    prometedor.Add(origen);
                }

            }

            return prometedor;
        }

        private Arista seleccion(ListaAristas candidatos, string subGrafo)
        {
            Arista aux = new Arista();
            int indice = new int();
            for(int i = 0; i < candidatos.Count; i++)
            {
                if(subGrafo.Contains(candidatos[i].Origen))//si la cadena subgrafo contiene el origen pero no el destino se utiliza
                {
                    if (!subGrafo.Contains(candidatos[i].getDestino()))
                    {
                        indice = i;
                        aux = candidatos[i];
                        break;
                    }
                }
                else
                {
                    if (subGrafo.Contains(candidatos[i].getDestino()))
                    {
                        indice = i;
                        aux = candidatos[i];
                        break;
                    }
                }
            }
            candidatos.RemoveAt(indice);
            return aux;
        }

        public string[,] Dijkstra(int nodoOrigen)
        {
            ListaAristas candidatos = new ListaAristas();
            int[] vectorDistancias = new int[this.Count];
            int nodoDefinitivo = new int();
            int pesoActual = new int();
            bool[] definitivos = new bool[this.Count];
            string[,] pesoXruta = new string[this.Count, 2];

            for (int i = 0; i < this.Count; i++)
            {
                for (int j = 0; j < this[i].getListAristas().Count; j++)
                {
                    candidatos.Add(this[i].getListAristas()[j]);
                }
            }
            quickSortChar(ref candidatos, 0, candidatos.Count - 1);

            for (int i = 0; i < this.Count; i++)
            {
                vectorDistancias[i] = int.MaxValue;
                pesoXruta[i,1] = this[i].getOrigen().ToString();
            }
            //Inicializando nodo origen
            vectorDistancias[nodoOrigen] = 0;
            nodoDefinitivo = nodoOrigen;
            definitivos[nodoOrigen] = true;
            pesoXruta[nodoOrigen, 0] = 0.ToString();
            pesoXruta[nodoOrigen, 1] += this[nodoOrigen].getOrigen().ToString();
            //
            int nodoAnterior = new int();
            for (int i = 0; i < this.Count; i++)
            {
                nodoAnterior = nodoDefinitivo;
                actualizarVector(ref vectorDistancias, nodoDefinitivo, nodoAnterior, pesoActual, definitivos, candidatos, ref pesoXruta);
                nodoDefinitivo = seleccion(vectorDistancias, definitivos);
                if (nodoDefinitivo == -1)
                    break;
                pesoActual = vectorDistancias[nodoDefinitivo];
                definitivos[nodoDefinitivo] = true;
                pesoXruta[nodoDefinitivo, 0] = vectorDistancias[nodoDefinitivo].ToString();
                
            }

            return pesoXruta;
        }

        private void actualizarVector(ref int[] vector, int nodoOrigen, int nodoAnterior, int pesoActual, bool[] definitivos, ListaAristas candidatos, ref string[,] pesoXruta)
        {
            for(int i = 0; i < candidatos.Count; i++)
            {
                if(this[nodoOrigen].getOrigen() == candidatos[i].Origen)
                {
                    for(int j = 0; j < this.Count; j++)
                    {
                        if (this[j].getOrigen() == candidatos[i].getDestino() && !definitivos[j])
                        {
                            if (vector[j] > candidatos[i].Peso + pesoActual)
                            {
                                vector[j] = pesoActual + candidatos[i].Peso;
                                pesoXruta[j, 1] = this[nodoAnterior].getOrigen().ToString();
                            }
                        }
                    }
                }              
            }
        }

        private int seleccion(int[] vector, bool[] definitivos)
        {
            int menor = int.MaxValue;
            int seleccionado = -1;
            for(int i = 0; i < vector.Length; i++)
            {
                if(vector[i] < menor && !definitivos[i])
                {
                    menor = vector[i];
                    seleccionado = i;
                }

            }
            return seleccionado;
        }

        private int contiene(char origen)
        {
            for(int i = 0; i < this.Count; i++)
            {
                if (this[i].getOrigen() == origen)
                    return i;
            }
            return -1;
        }

        public void quickSort(ref ListaAristas listaAristas, int primero, int ultimo)
        {
            int i, j, central;
            Arista pivote;
            central = (primero + ultimo) / 2;
            pivote = listaAristas[central];
            i = primero;
            j = ultimo;

            do
            {
                while (listaAristas[i].Peso < pivote.Peso)
                {
                    i++;
                    if (i > ultimo)
                        break;
                }

                while (listaAristas[j].Peso > pivote.Peso)
                {
                    j--;
                    if (j < primero)
                        break;
                }

                if (i <= j)
                {
                    Arista temp;
                    temp = listaAristas[i];
                    listaAristas[i] = listaAristas[j];
                    listaAristas[j] = temp;
                    i++;
                    j--;
                }


            } while (i <= j);

            if (primero < j)
            {
                quickSort(ref listaAristas, primero, j);
            }
            if (i < ultimo)
            {
                quickSort(ref listaAristas, i, ultimo);
            }
        }

        public void quickSortChar(ref ListaAristas listaAristas, int primero, int ultimo)
        {
            int i, j, central;
            Arista pivote;
            central = (primero + ultimo) / 2;
            pivote = listaAristas[central];
            i = primero;
            j = ultimo;

            do
            {
                while (listaAristas[i].Origen < pivote.Origen)
                {
                    i++;
                    if (i > ultimo)
                        break;
                }

                while (listaAristas[j].Origen > pivote.Origen)
                {
                    j--;
                    if (j < primero)
                        break;
                }

                if (i <= j)
                {
                    Arista temp;
                    temp = listaAristas[i];
                    listaAristas[i] = listaAristas[j];
                    listaAristas[j] = temp;
                    i++;
                    j--;
                }


            } while (i <= j);

            if (primero < j)
            {
                quickSort(ref listaAristas, primero, j);
            }
            if (i < ultimo)
            {
                quickSort(ref listaAristas, i, ultimo);
            }
        }
    }
}
