/*
Project: TrabalhandoComListas
Author: Francielly Lima
Date: 02/03/2020
Description: Classe que realiza a soma dos números de 1 a 20 que são dividíveis por 3.
*/

using System;

namespace TrabalhandoComListas
{
    public class Listas
    {

      var names = new List<string>{"Fran", "Ana", "Edu"};
      foreach (var name in names){
       Console.WriteLine($"Hello {name.ToUpper()}!");
}

//----------------------------
//Adicionar ou Remover um nome
//----------------------------
      Console.WriteLine(); //Imprime uma linha em branco.
      names.Add("Maria");
      names.Add("Bill");
      names.Remove("Ana");
      
      foreach(var name in names){
        Console.WriteLine($"Hello {name.ToUpper()}!");
}

//----------------------------
//Por índices
//----------------------------
      Console.WriteLine();
      Console.WriteLine($"My name is {names[0]}.");
      Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");

      Console.WriteLine($"The list has {names.Count} people in it"); //Contabilida a quantidade de itens na lista.
      //----------------------------
//Pesquisar itens pelo Index
//----------------------------
      var index = names.IndexOf("Edu");
      if (index != -1){
      Console.WriteLine($"The name {names[index]} is at index {index}");

      var notFound = names.IndexOf("Not Found");
      Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");
}

//----------------------------
//Classificar lista
//----------------------------

      names.Sort();
      foreach (var name in names){
      Console.WriteLine($"Hello {name.ToUpper()}!");
    }
   }
}
