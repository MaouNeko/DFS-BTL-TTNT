using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Btl_DFS
{
    public partial class font1 : Form
    {
        private Graph graph;

        public font1()
        {
            InitializeComponent();
        }


        private void btnInitializeGraph_Click(object sender, EventArgs e)
        {
            int numVertices = (int)numNumVertices.Value;
            graph = new Graph(numVertices);
            lstEdges.Items.Clear();
            lstDFSResult.Items.Clear();
        }

        private void btnAddEdge_Click(object sender, EventArgs e)
        {
            int v = (int)numVertex1.Value;
            int w = (int)numVertex2.Value;

            graph.AddEdge(v, w);
            lstEdges.Items.Add($"Edge: {v} - {w}");
        }

        private void LoadEvent(object sender, EventArgs e)
        {

        }

        private void btnDFS_Click(object sender, EventArgs e)
        {
            int startVertex = (int)numStartVertex.Value;

            lstDFSResult.Items.Clear();

            List<int> dfsTraversal = graph.DFS(startVertex);
            foreach (int vertex in dfsTraversal)
            {
                lstDFSResult.Items.Add(vertex);
            }
        }
    }

    public class Graph
    {
        private int V;
        private List<int>[] adjacencyList;

        public Graph(int v)
        {
            V = v;
            adjacencyList = new List<int>[v];
            for (int i = 0; i < v; i++)
            {
                adjacencyList[i] = new List<int>();
            }
        }

        public void AddEdge(int v, int w)
        {
            adjacencyList[v].Add(w);
            adjacencyList[w].Add(v);
        }

        public List<int> DFS(int startVertex)
        {
            bool[] visited = new bool[V];
            List<int> dfsTraversal = new List<int>();
            DFSUtil(startVertex, visited, dfsTraversal);
            return dfsTraversal;
        }

        private void DFSUtil(int vertex, bool[] visited, List<int> dfsTraversal)
        {
            visited[vertex] = true;
            dfsTraversal.Add(vertex);

            foreach (int neighbor in adjacencyList[vertex])
            {
                if (!visited[neighbor])
                {
                    DFSUtil(neighbor, visited, dfsTraversal);
                }
            }
        }
    }
}
