using System;

class Program {
  static bool esPositivo(int numero){
    bool respuesta;
    respuesta = numero>0; //almacenando un resultado de una consulta logica(verdadero o falso)
    return respuesta;
  }
  public static void Main (string[] args) {
    int numero;
    Console.WriteLine ("ingrese un numero");
    numero= int.Parse(Console.ReadLine());

    Console.WriteLine("el resultado es: " + esPositivo(numero));

    //if(esPositivo(numero))
     // Console.WriteLine("el numero es positivo");
   // else
     // Console.WriteLine("el numero es negativo");  
  }
}