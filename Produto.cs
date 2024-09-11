class Produto
{
    public string nome;
    public int quantidade;
    public double preco;
    public void AdicionarEstoque(int valor)
    {
        if(valor > 0){
        quantidade += valor;
        Console.WriteLine($"A quantidade {valor} foi adicionada ao produto {nome}");}
        else{Console.WriteLine("Erro: Digite um valor válido!")
        Console.ReadKey();
        }
    }

    public void RemoverEstoque(int valor)
    {
        if(valor > 0 && valor <= quantidade){
        quantidade -= valor;
        Console.WriteLine($"A quantidade {valor} foi removida do produto {nome}");}
        else if(valor <= 0){
            Console.WriteLine("O valor informado é menor ou igual a 0");
        }
        else{
            Console.WriteLine("O valor informado é maior que a quantidade disponivel em estoque");
        }
    }
    public double CalcularValorEstoque()
    {
        return quantidade * preco;
    }

    public void DefinirValores()
    {
        Console.WriteLine("1 - Informeo nome do produto: ");
        nome = Console.ReadLine();
        Console.WriteLine("2 - Informe a quantidade em estoque: ");
        quantidade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("3 - Informe o preço do produto: ");
        preco = Convert.ToDouble(Console.ReadLine());
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine("Nome do produto: " + nome);
        Console.WriteLine("Quantidade em estoque do produto: " + quantidade);
        Console.WriteLine("Preço unitario do produto: " + preco);
        Console.WriteLine("Valor total em estoque: " + CalcularValorEstoque());
    }
}