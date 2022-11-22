/*

Uma empresa de consultoria deseja avaliar a performance de produtos,funcionários, dentre outras coisas. Um dos cálculos que ela precisa é encontrar o maior dentre um conjunto de elementos. Fazer um programa que leia um conjunto de N produtos, conforme exemplo, e depois mostre o mais caro deles.

Enter N: 3 
Computer,890.50
IPhone X,910.00
Tablet,550.00
Max:
IPhone, 910.00

*/


using System;
using System.Collections.Generic;

using System.Globalization;
class Program {
    static void Main(string[] args) {

        List<Product> list = new List<Product>();

        Console.Write("Enter the number of products: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++) {
            string[] vect = Console.ReadLine().Split(',');
            double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
            list.Add(new Product(vect[0], price));
        }

        CalculationService calculationService = new CalculationService();

        Product p = calculationService.Max(list); // <Product> is optional

        Console.WriteLine("Most expensive:");
        Console.WriteLine(p);
    }

    public class CalculationService{
        public T Max<T>(List<T> list) where T : IComparable  { // metodo generico, para comparar logicamente necessita de escrever where T : IComparable
            if (list.Count == 0) {
                throw new ArgumentException("The list can not be empty");
            }

            T max = list[0];
            for (int i = 0; i < list.Count; i++) {
                if (list[i].CompareTo(max) > 0) { // nao eh possivel apenas usar list[i] > max, por isso usa o compareTo > 0, pois se o elemento list[i] for maior que max sera retornado um valor maior que 0
                    max = list[i];
                }
            }
            return max;
        }
    }


    class Product : IComparable {

        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        public int CompareTo(object obj) {
            if (!(obj is Product)) {
                throw new ArgumentException("Comparing error: argument is not an Product");
            }
            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }

        public override string ToString() {
            return Name
                + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}