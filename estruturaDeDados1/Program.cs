NewMethod();

static void NewMethod()
{
    //   //TRABALHANDO COM LISTA (LIST)
    //   List<string> frutas = new List<string>();
    //   frutas.Add("Morango");
    //   frutas.Add("Manga");
    //   frutas.Add("Goiaba");
    //   frutas.Add("Uva");

    //   //IMPRIMIR OS ITENS DA LISTA
    //   Console.WriteLine("Minha lista de Frutas");
    //   foreach (string fruta in frutas)
    //   {
    //       Console.WriteLine(fruta);
    //   }

    //   Console.WriteLine();
    //   //Pular linha em branco 

    //   //IMPRIMIR ELEMENTO NA POSIÇÃO ESPECÍFICA
    //   Console.WriteLine("Fruta na indice 2: " + frutas[2]);
    //   //adicionando elemento na lista 
    //   frutas.Insert(1, "Maracuja");

    //   //IMPRIMIR OS ITENS DA LISTA
    //   Console.WriteLine("Minha lista de Frutas");
    //frutas.ForEach(console.WriteLine)

    //   //alterar um elemento no indice específico 
    //   frutas[4] = "Pera";

    //   //IMPRIMIR OS ITENS DA LISTA
    //   Console.WriteLine("Minha lista de Frutas");
    //   foreach (string fruta in frutas)
    //   {
    //       Console.WriteLine(fruta);
    //   }

    //   //remover elementos da lista no indice especifico 
    //   frutas.RemoveAt(3);
    //   //remover elemento pelo valor do conteudo
    //   frutas.Remove("Morango");

    //   //Imprimindo a lista novamente a lista 
    //   Console.WriteLine("Minha lista de Frutas");
    //   foreach (string fruta in frutas)
    //   {
    //       Console.WriteLine(fruta);
    //   }
    //   //apagar todos os elementos da lista 
    //   frutas.Clear();
    //   Console.WriteLine("Minha lista de Frutas");
    //   foreach (string fruta in frutas)
    //   {
    //       Console.WriteLine(fruta);
    //   }

    List<string> frutas = new List<string> { "Morango", "Manga", "Goiaba", "Uva" };
    //Imprimindo elementos um uma única linha 
    Console.WriteLine("Minha Lista de Frutas:");
    frutas.ForEach(Console.WriteLine);

    Console.WriteLine("\nFruta no índice 2: " + frutas[2]);

    frutas.Insert(1, "Maracujá");
    frutas[4] = "Pêra";

    Console.WriteLine("\nLista Atualizada:");
    frutas.ForEach(Console.WriteLine);

    frutas.RemoveAt(3);
    frutas.Remove("Morango");

    Console.WriteLine("\nLista Após Remoções:");
    frutas.ForEach(Console.WriteLine);

    frutas.Clear();

    // TRABALHANDO COM DICIONARIO (DICIONARY)
    Dictionary<int, string> carros = new Dictionary<int, string>();
    //Adicionar dados a um Dicionario
    carros.Add(5, "Corsa");
    carros.Add(10, "Fusca");
    carros.Add(2, "Ford Ka");

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine("Meu Dicionario de Carros");
    //imprimir um dicionario de dados 
    foreach (var carro in carros)
    {
        Console.WriteLine($"{carro.Key} - {carro.Value}");
    }
    // TRabalhando com fila
    // criar uma fila (queue)

    Queue<string> FilaBanco = new Queue<string>();
    FilaBanco.Enqueue("André");
    FilaBanco.Enqueue("josé");
    FilaBanco.Enqueue("mazzi");
    FilaBanco.Enqueue("bruno");

    foreach (var pessoa in FilaBanco)
    {
        Console.WriteLine(pessoa);
    }
    FilaBanco.Dequeue();

    Console.WriteLine();
    Console.WriteLine("===============");
    Console.WriteLine();
    foreach (var pessoa in FilaBanco)
    {

        Console.WriteLine(pessoa);
    }

    // verificar se existe um elemento na fila

    bool achou = FilaBanco.Contains("manoel");
    if (achou)
    {
        Console.WriteLine("A pessoa está na fila");
    }
    else
    {
        Console.WriteLine("A pessoa NÃO está na Fila");
    }

    Console.WriteLine();
    Console.WriteLine("===============");
    Console.WriteLine();

    // TRABALHANDO COM  PILHA (STACK)
    Stack<string> Livros = new Stack<string>();
    //adicionar elementos em uma pilha
    Livros.Push("Chapeu");
    Livros.Push("Mazzi o incio");
    Livros.Push("Mazzi o fim");

    foreach (var Livro in Livros)
    {
        Console.WriteLine(Livro);
    }

    Console.WriteLine();
    Console.WriteLine("===============");
    Console.WriteLine();
}


