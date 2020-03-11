using System;
[System.Serializable]
//This class is to store a vertex's neighbour with the cost.
public class Edge : IComparable<Edge>
{
    public float cost;
    public Vertex vertex;
    //Next Steps

    //Classes constructor
    public Edge(Vertex vertex = null,float cost = 1f)
    {
        this.vertex = vertex;
        this.cost = cost;
    }
    //Comparsion member function
    public int CompareTo(Edge other)
    {
        float result = cost - other.cost;
        int idA = vertex.GetInstanceID();
        int idB = other.vertex.GetInstanceID();

        if (idA == idB)
            return 0;

        return(int) result;
    }
    //Function for comparing edges
    public bool Equals(Edge other)
    {
        return (other.vertex.id == this.vertex.id);
    }
    //Overriding the function for comparing two objects
    public override bool Equals(object obj)
    {
        Edge other = (Edge)obj;
        return (other.vertex.id) == this.vertex.id;
    }
    /*Overriding the function to retrieve the hash code.
      This is neccesary  when overriding the previous member function*/
    public override int GetHashCode()
    {
        return this.vertex.GetHashCode();
    }
}
