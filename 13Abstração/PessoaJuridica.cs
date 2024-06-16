class PessoaJuridica : Padrao
{
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de empréstimo para pessoa jurírica R$ " + (valor * 0.2));
    }
        
    
}