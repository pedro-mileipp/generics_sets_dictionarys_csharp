using System;
using System.Collections.Generic;

/*

==> HashSet e SortedSet

- Os Conjuntos em C# são representados pelas coleções HashSet e SortedSet;

- Representa um conjunto de elementos (similar ao da Álgebra):
  - Não admite repetições;
  - Elementos não possuem posição;
  - Acesso, inserção e remoção de elementos são rápidosç
  - Oferece operações eficientes de conjunto: interseção, união, diferença

-> Diferenças

- HashSet:
  - Armazenamento em tabela hash;
  - Extramamente rápido: inserção, remoção e busca O(1);
  - A ordem dos elementos não é garantida.

- SortedSet:
  - Armazenamento em árvore;
  - Rápido: inserção, remoção e busca O(log(n)); 
  - Os elementos são armazenados ordenadamente conforme implementação IComparer<T>. 

-> Alguns métodos importantes (HashSet e SortedSet)
  - Add: Adiciona um elemento;
  - Clear: Limpar o conjunto, esvaziar a coleção;
  - Contains: Verificar se um elemento está contino no conjunto;
  - UnionWith(other): Operação união: adiciona no conjunto os elementos do outro conjunto, sem repetição;
  - IntersectWith(other): Operação interseção: remove do conjunto os elementos não contidos em other;
  - ExceptWith(other): Operação diferença: remove do conjunto elementos contidos em other;
  - Remove(T): Remover um elemento do conjunto;
  - RemoveWhere(predicate): Remove os elementos que atendem a condição de predicate.

*/

class Program{
    static void Main(){
        Sep();
        HashSet<string> set = new HashSet<string>(); // para usar SortedSet basta substituir no lugar de HashSet e vice-versa, a forma de fazer é a mesma.
        set.Add("TV");
        set.Add("Smartphone");
        set.Add("Notebook");
        Console.WriteLine("Testando se Notebook está no conjunto set (true or false): ");
        Console.WriteLine(set.Contains("Notebook"));
        Console.WriteLine("Testando se Computador está no conjunto set (true or false): ");
        Console.WriteLine(set.Contains("Computador"));
        Console.WriteLine();

        Console.WriteLine("IMPRIMINDO O CONJUNTO: ");
        foreach(string s in set){
            Console.WriteLine(s);
        }
        Sep();

        SortedSet<int> A = new SortedSet<int> {1, 2, 3, 4, 5};
        SortedSet<int> B = new SortedSet<int> {6, 7, 8, 9, 10};
        PrintCollection(A);
        PrintCollection(B);
        Sep();

        // união
        System.Console.WriteLine("UNIÃO DE CONJUNTOS:");
        SortedSet<int> C = new SortedSet<int>(A);
        C.UnionWith(B);
        PrintCollection(C);
        Sep();

        // Interseção
        System.Console.WriteLine("INTERSEÇÃO DE CONJUNTOS:");
        SortedSet<int> D = new SortedSet<int>{10, 20, 30, 40, 50};
        SortedSet<int> E = new SortedSet<int>{10, 20, 30, 60, 70};
        D.IntersectWith(E);
        PrintCollection(D);
        Sep();

        // Diferença
        System.Console.WriteLine("DIFERENÇA DE CONJUNTOS:");
        SortedSet<int> F = new SortedSet<int>{10, 20, 30, 40, 50};
        SortedSet<int> G = new SortedSet<int>{10, 20, 30, 60, 70};
        F.ExceptWith(G);
        PrintCollection(F);


    }

    static void PrintCollection<T> (IEnumerable<T> collection){
        foreach (T obj in collection){
            Console.Write(obj + " ");
        }
        Console.WriteLine();
    }

    static void Sep(){
        Console.WriteLine();
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine();
    }
}
