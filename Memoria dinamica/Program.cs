
//MEMORIA DINAMICA

List<int> numeros = new List<int>();

numeros.Add(10);
numeros.Add(20);
numeros.Add(30);

Console.WriteLine("Elementos en la lista:");
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}

Console.WriteLine("Primer elemento: " + numeros[0]);
Console.WriteLine("Segundo elemento: " + numeros[1]);
Console.WriteLine("Tercer elemento: " + numeros[2]);

numeros[1] = 120;
Console.WriteLine("Segundo elemento modificado: " + numeros[1]);

numeros.RemoveAt(0);
Console.WriteLine("Elemento en la posición 0 eliminado.");


Console.WriteLine("Elementos en la lista después de las modificaciones:");
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}