using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    public GameObject vertexPrefab; // This variable is for the ground.
    protected List<Vertex> vertices; 
    protected List<List<Vertex>> neighbours;
    protected List<List<float>> costs;
    //next steps
    void Start()
    {
        Load();
    }

    public virtual void Load()
    {

    }

    //Function to get the grid's size
    public virtual int GetSize()
    {
        if(ReferenceEquals(vertices, null))
            return 0;
        return vertices.Count;
    }
    //Funtion to get the nearest vertex given a position
    public  virtual Vertex[] GetVertex(int id)
    {
        return null;
    }

    
}
