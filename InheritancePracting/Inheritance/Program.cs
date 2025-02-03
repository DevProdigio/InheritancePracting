using System;
using Inheritance;

class Program
{
    static void Main(string[] args)
    {
        Carro carro = new Carro { Marca = "Toyota", Ano = 2006, NumeroPortas = 4 };
        Moto moto = new Moto { Marca = "Honda" , Ano = 2008, Cilindrada = 200};

        carro.LigarMotor();
        carro.AbrirPortas();

        moto.LigarMotor();
        moto.Empinar();
    }
}