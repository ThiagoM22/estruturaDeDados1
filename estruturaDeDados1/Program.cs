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


}


