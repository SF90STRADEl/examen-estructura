public class Nodo
{
    public int Info { get; set; }
    public Nodo Ant { get; set; }
    public Nodo Sig { get; set; }

    public Nodo(int info)
    {
        Info = info;
        Ant = null;
        Sig = null;
    }
}