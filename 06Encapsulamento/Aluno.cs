class Aluno
{
    // Atributos
    private double nota1, nota2;

    // Média
    private double media()
    {
        return (nota1+nota2) / 2;
    }

    public void mensagem()
    {
        Console.WriteLine("Informe a primeira nota:");
        nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe a segunda nota:");
        nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("A média é " + media());

    }

}
