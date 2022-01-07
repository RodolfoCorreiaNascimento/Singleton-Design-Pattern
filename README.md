# Singleton Design Pattern
Creating a singleton design pattern.

## Define:
Singleton is a software design pattern. 
This pattern guarantees the existence of only one instance of a class, 
maintaining a global access point to its object.

## Link utéis para informações específicas:
https://pt.wikipedia.org/wiki/Singleton

### Objetivo: 
Nesse pequeno código demonstro a criação de um singleton na prática
ultilizando o visual code e a linguagem c# na plataforma .net

### Exemplo mais fácil de entender:
Em C#
Segue um exemplo em C# da implementação de uma classe Singleton:

using System;

public class MyClass
{
   private static MyClass instance;

   private MyClass() {}

   public static MyClass Instance
   {
      get
      {
         if (instance == null)
         {
            instance = new MyClass();
         }
         return instance;
      }
   }
}

#### Obs: Referência extraída do wikipedia.
