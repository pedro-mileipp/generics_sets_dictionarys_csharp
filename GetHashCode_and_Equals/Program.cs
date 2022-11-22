using System;
using GetHashCode_and_Equals;

/*

==> GetHashCode e Equals

- São operações da classe Object para comparar se um objeto é igual a outro;

- Equals: lento, resposta 100%;

- GetHashCode: rápido, porém resposta positiva não é 100%;

- Os tipos pré-definidos já possuem implementação para essas operações. Classes e structs precisam sobrepô-las.

*/

class Program{
    static void Main(){

        // Equals: Método que compara se o objeto é igual a outro, retornando true or false

        Sep();
        string a = "Pedro"; 
        string b = "Miguel";
        string c = "Pedro";
        Console.WriteLine("Equals: Método que compara se o objeto é igual a outro, retornando true or false");
        Console.WriteLine();
        Console.WriteLine("Variável a = Pedro é igual a variável b = Miguel: {0}", a.Equals(b)); // retornará False, pois {a} é "Pedro" e {b} Miguel
        Console.WriteLine("Variável a = Pedro é igual a variável c = Pedro: {0}",c.Equals(a)); // retornará True, pois {c} é "Pedro" e {a} também é Pedro
        Sep();
        
        // GetHashCode: Retornará um número inteiro representando um código gerado a partir das informações do objeto. Nos dá o código hash do objeto
        Console.WriteLine("GetHashCode: Retornará um número inteiro representando um código gerado a partir das informações do objeto. Nos dá o código hash do objeto");
        Console.WriteLine();
        Console.WriteLine(a.GetHashCode());
        Console.WriteLine(b.GetHashCode());
        Console.WriteLine(c.GetHashCode());
        Sep();
        
        // Aplicando em classes
        Console.WriteLine("TESTE COM CLASSES");
        Console.WriteLine();
        Client A = new Client{ Name = "Pedro", Email = "pedro@proton.com"};
        Client B = new Client{ Name = "Miguel", Email = "miguel@proton.com"};
        Client C = new Client{ Name = "Alice", Email = "pedro@proton.com"};

        Console.WriteLine("Comparando se A é igual a C: Apesar do atributo Name ser diferente, retornará verdadeiro, pois lá na classe foi definido como critério de comparação o atributo Email.");
        Console.WriteLine(A.Equals(C));
        Console.WriteLine();
        Console.WriteLine("Já B não é igual a A, pois os emails são diferentes");
        Console.WriteLine(B.Equals(A));

        Sep();
        System.Console.WriteLine("Testando com o Hash code dos objetos");
        Console.WriteLine("Hash code de A: {0}", A.GetHashCode());
        Console.WriteLine("Hash code de B: {0}", B.GetHashCode());
        Console.WriteLine("Hash code de C: {0}", C.GetHashCode());
        Sep();
    }

    static void Sep(){
        System.Console.WriteLine();
        System.Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        System.Console.WriteLine();
    }
}
