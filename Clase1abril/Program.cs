void arreglos()
{
    String[] nombre = new String[] {
        "Fernanda ", "Melvin", "Luis", "Brandon", "Yamileth"

    };
    foreach (String n in nombre)
    {
        Console.WriteLine(n);
    }
}
int[] notas = new int[]
{
    70,90,43,85,30
};
int promedio = 0;
foreach (int i in notas) {
    promedio = promedio + i;
}
    promedio = promedio / notas.Length;
Console.WriteLine($"El promedio es : {promedio}");

arreglos();