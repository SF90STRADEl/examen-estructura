class Program
{
    static void Main(string[] args)
    {
        ListaGenericaDoble lg = new ListaGenericaDoble();
        int opcion;
        do
        {
            Console.WriteLine("\n--- Menú de Lista Interactiva ---");
            Console.WriteLine("1. Insertar elemento");
            Console.WriteLine("2. Borrar elemento por posición");
            Console.WriteLine("3. Borrar elemento por valor");
            Console.WriteLine("4. Extraer elemento");
            Console.WriteLine("5. Intercambiar elementos");
            Console.WriteLine("6. Imprimir lista");
            Console.WriteLine("7. Verificar si existe un elemento");
            Console.WriteLine("8. Encontrar el mayor elemento");
            Console.WriteLine("9. Verificar si la lista está ordenada");
            Console.WriteLine("10. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese la posición: ");
                    int pos = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el valor: ");
                    int valor = int.Parse(Console.ReadLine());
                    lg.Insertar(pos, valor);
                    break;
                case 2:
                    Console.Write("Ingrese la posición a borrar: ");
                    int posBorrar = int.Parse(Console.ReadLine());
                    lg.Borrar(posBorrar);
                    break;
                case 3:
                    Console.Write("Ingrese el valor a borrar: ");
                    int valorBorrar = int.Parse(Console.ReadLine());
                    lg.BorrarPorValor(valorBorrar);
                    break;
                case 4:
                    Console.Write("Ingrese la posición a extraer: ");
                    int posExtraer = int.Parse(Console.ReadLine());
                    int extraido = lg.Extraer(posExtraer);
                    Console.WriteLine("Elemento extraído: " + extraido);
                    break;
                case 5:
                    Console.Write("Ingrese la primera posición: ");
                    int pos1 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la segunda posición: ");
                    int pos2 = int.Parse(Console.ReadLine());
                    lg.Intercambiar(pos1, pos2);
                    break;
                case 6:
                    Console.WriteLine("Lista actual:");
                    lg.Imprimir();
                    break;
                case 7:
                    Console.Write("Ingrese el valor a buscar: ");
                    int buscar = int.Parse(Console.ReadLine());
                    if (lg.Existe(buscar))
                        Console.WriteLine("El valor existe en la lista.");
                    else
                        Console.WriteLine("El valor no existe en la lista.");
                    break;
                case 8:
                    int mayor = lg.Mayor();
                    Console.WriteLine("El mayor elemento es: " + mayor);
                    break;
                case 9:
                    if (lg.Ordenada())
                        Console.WriteLine("La lista está ordenada.");
                    else
                        Console.WriteLine("La lista no está ordenada.");
                    break;
                case 10:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (opcion != 10);
    }
}