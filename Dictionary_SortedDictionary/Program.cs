using System;
using System.Collections.Generic;
/*

=> Dictionary<TKey, TValue> e 

- É uma coleção de pares chave / valor
    - Não admite repetição do objeto chave;
    - Os elementos são indexados pelo objeto chave (não possuem posição);
    - Acesso, inserção e remoção de elementos são rápidos.

- Uso comum: cookies, local storage, qualquer modelo chave-valor.

--> Diferenças (Dictionary e SortedDictionary)

- Dictionary
    - Armazenamento em tabela Hash;
    - Extramamente rápido: inserção, remoção e busca O(1);
    - A ordem dos elementos não é garantida.

- SortedDictionary
    - Armazenamento em árvore;
    - Rápido: inserção, reoção e busca O(log(n));
    - Os elementos são armazenados ordenadamente conforme implementação IComparer<T>;

--> Alguns métodos importantes
    - dictionary[key] - acessa o elemento pela chave informada;
    - Add(key, value) - adiciona elemento (exceção em caso de repetição); 
    - Clear() - esvazia a coleção;
    - Count - quantidade de elementos;
    - ContainsKey(key) - verifica se a dada chave existe;
    - ContainsValue(value) - verifica se o dado valor existe;
    - Remove(key) - remove um elemento pela chave;

*/

class Program{
    static void Main(){

        Dictionary<string, string> cookies = new Dictionary<string, string>(); // para usar SortedDictionary basta fazer o mesmo mas com o próprio
        cookies["user"] = "maria";
        cookies["email"] = "maria@gmail.com";
        cookies["phone"] = "99771133";
        cookies["phone"] = "99771122";
        Console.WriteLine(cookies["email"]);
        Console.WriteLine(cookies["phone"]);
        Sep();

        cookies.Remove("email");
        Console.WriteLine("Phone number: " + cookies["phone"]);
        if (cookies.ContainsKey("email")) {
        Console.WriteLine("Email: " + cookies["email"]);
        }
        else {
        Console.WriteLine("There is not 'email' key");
        }
        Sep();

        Console.WriteLine("Size: " + cookies.Count);

        Console.WriteLine("ALL COOKIES:");
        foreach (KeyValuePair<string, string> item in cookies) {
        Console.WriteLine(item.Key + ": " + item.Value);
        }


    }

    static void Sep(){
        Console.WriteLine();
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine();
    }
}