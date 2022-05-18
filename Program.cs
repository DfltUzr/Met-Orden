int[] a = new int[4];

a[0] = 33;
a[1] = 1;
a[2] = 80;
a[3] = 20;

int aux = 0;
int n = a.Length;

//Console.WriteLine("Bubble");
//bubble();
//Console.WriteLine();
//Console.WriteLine();
Console.WriteLine("Inserción Directa");
inserciondirecta();
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine("Selección Directa");
//selecciondirecta();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Ingrese El Elemento Que Desea Buscar: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine();
busquedabinaria(num);
Console.ReadLine();

void bubble()
{
    for (int i = 0; i < n -1; i++)
    {
        for (int j = i +1; j < n; j++)
        {
            if (a[i] > a[j])
            {
                aux = a[i];
                a[i] = a[j];
                a[j] = aux;
            }
        }
    }
    foreach (int dato in a)
    {
        Console.Write("{0} ", dato);
    }
}

void inserciondirecta()
{
    for (int i = 1; i < n; i++)
    {
        int j = i - 1;
        while ((j >= 0) && (a[j] > a[j + 1]))
        {
            aux = a[j];
            a[j] = a[j + 1];
            a[j + 1] = aux;
            j--;
        }
    }
    foreach (int dato in a)
    {
        Console.Write("{0} ", dato);
    }
}

void selecciondirecta()
{
    for (int i = 0; i < n - 1; i++)
    {
        int menor = i;
        for (int j = i + 1; j < n; j++)
        {
            if (a[j] < a[menor])
            {
                menor = j;
            }
        }
        if (i != menor)
        {
            aux = a[i];
            a[i] = a[menor];
            a[menor] = aux;
        }
    }
    foreach (int dato in a)
    {
        Console.Write("{0} ", dato);
    }
}

void busquedabinaria (int no)
{
    int l = 0, m = 0, h = 4;
    bool encontro = false;

    while (l < h && encontro == false)
    {
        m = (l + h) / 2;
        if (a[m] == no)
        {
            encontro = true;
        }
        if (a[m] > no)
        {
            h = m - 1;
        }
        else
        {
            l = m + 1;
        }
    }
    if (encontro == false)
    {
        Console.WriteLine("El Elemento {0} No Está En El Arreglo ", no);
    }
    else
    {
        Console.WriteLine("El Elemento {0} Está En La Posición: {1} ", no, m + 1);
    }
}