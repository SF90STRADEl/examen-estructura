public class ListaGenericaDoble
{
    private Nodo raiz;

    public ListaGenericaDoble()
    {
        raiz = null;
    }

    public void Insertar(int pos, int x)
    {
        if (pos <= Cantidad() + 1)
        {
            Nodo nuevo = new Nodo(x);
            if (pos == 1)
            {
                nuevo.Sig = raiz;
                if (raiz != null)
                    raiz.Ant = nuevo;
                raiz = nuevo;
            }
            else if (pos == Cantidad() + 1)
            {
                Nodo reco = raiz;
                while (reco.Sig != null)
                {
                    reco = reco.Sig;
                }
                reco.Sig = nuevo;
                nuevo.Ant = reco;
            }
            else
            {
                Nodo reco = raiz;
                for (int f = 1; f <= pos - 2; f++)
                    reco = reco.Sig;
                Nodo siguiente = reco.Sig;
                reco.Sig = nuevo;
                nuevo.Ant = reco;
                nuevo.Sig = siguiente;
                siguiente.Ant = nuevo;
            }
        }
    }

    public int Extraer(int pos)
    {
        if (pos <= Cantidad())
        {
            int informacion;
            if (pos == 1)
            {
                informacion = raiz.Info;
                raiz = raiz.Sig;
                if (raiz != null)
                    raiz.Ant = null;
            }
            else
            {
                Nodo reco = raiz;
                for (int f = 1; f <= pos - 2; f++)
                    reco = reco.Sig;
                Nodo prox = reco.Sig;
                reco.Sig = prox.Sig;
                Nodo siguiente = prox.Sig;
                if (siguiente != null)
                    siguiente.Ant = reco;
                informacion = prox.Info;
            }
            return informacion;
        }
        else
            return int.MaxValue;
    }

    public void Borrar(int pos)
    {
        if (pos <= Cantidad())
        {
            if (pos == 1)
            {
                raiz = raiz.Sig;
                if (raiz != null)
                    raiz.Ant = null;
            }
            else
            {
                Nodo reco = raiz;
                for (int f = 1; f <= pos - 2; f++)
                    reco = reco.Sig;
                Nodo prox = reco.Sig;
                prox = prox.Sig;
                reco.Sig = prox;
                if (prox != null)
                    prox.Ant = reco;
            }
        }
    }

    public void BorrarPorValor(int valor)
    {
        Nodo reco = raiz;
        while (reco != null)
        {
            if (reco.Info == valor)
            {
                if (reco.Ant == null) // Es el primer nodo
                {
                    raiz = reco.Sig;
                    if (raiz != null)
                        raiz.Ant = null;
                }
                else
                {
                    reco.Ant.Sig = reco.Sig;
                    if (reco.Sig != null)
                        reco.Sig.Ant = reco.Ant;
                }
                Console.WriteLine($"Elemento {valor} eliminado.");
                return;
            }
            reco = reco.Sig;
        }
        Console.WriteLine($"Elemento {valor} no encontrado.");
    }

    public void Intercambiar(int pos1, int pos2)
    {
        if (pos1 <= Cantidad() && pos2 <= Cantidad())
        {
            Nodo reco1 = raiz;
            for (int f = 1; f < pos1; f++)
                reco1 = reco1.Sig;
            Nodo reco2 = raiz;
            for (int f = 1; f < pos2; f++)
                reco2 = reco2.Sig;
            int aux = reco1.Info;
            reco1.Info = reco2.Info;
            reco2.Info = aux;
        }
    }

    public int Mayor()
    {
        if (!Vacia())
        {
            int may = raiz.Info;
            Nodo reco = raiz.Sig;
            while (reco != null)
            {
                if (reco.Info > may)
                    may = reco.Info;
                reco = reco.Sig;
            }
            return may;
        }
        else
            return int.MaxValue;
    }

    public int PosMayor()
    {
        if (!Vacia())
        {
            int may = raiz.Info;
            int x = 1;
            int pos = x;
            Nodo reco = raiz.Sig;
            while (reco != null)
            {
                if (reco.Info > may)
                {
                    may = reco.Info;
                    pos = x;
                }
                reco = reco.Sig;
                x++;
            }
            return pos;
        }
        else
            return int.MaxValue;
    }

    public int Cantidad()
    {
        int cant = 0;
        Nodo reco = raiz;
        while (reco != null)
        {
            reco = reco.Sig;
            cant++;
        }
        return cant;
    }

    public bool Ordenada()
    {
        if (Cantidad() > 1)
        {
            Nodo reco1 = raiz;
            Nodo reco2 = raiz.Sig;
            while (reco2 != null)
            {
                if (reco2.Info < reco1.Info)
                {
                    return false;
                }
                reco2 = reco2.Sig;
                reco1 = reco1.Sig;
            }
        }
        return true;
    }

    public bool Existe(int x)
    {
        Nodo reco = raiz;
        while (reco != null)
        {
            if (reco.Info == x)
                return true;
            reco = reco.Sig;
        }
        return false;
    }

    public bool Vacia()
    {
        return raiz == null;
    }

    public void Imprimir()
    {
        Nodo reco = raiz;
        while (reco != null)
        {
            Console.Write(reco.Info + "-");
            reco = reco.Sig;
        }
        Console.WriteLine();
    }
}