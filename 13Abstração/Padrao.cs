abstract class Padrao
{
    // Obrigatório
    public abstract void taxaEmprestimo(double valor);

    // Opcional
    public void calculoPoupanca(double valor, double taxa)
    {
        Console.WriteLine("Ganhos obtivos pela poupança R$ " + (valor * taxa));
    }
}