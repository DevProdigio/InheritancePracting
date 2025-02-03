using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Veiculo
    {
        public string Marca { get; set; }
        public int Ano { get; set; }

        public void LigarMotor()
        {

        }
    }

    class Carro : Veiculo
    {
        public int NumeroPortas { get; set; }

        public void AbrirPortas()
        {
            Console.WriteLine($"Abrindo {NumeroPortas} Portas");
        }
    }

    class Moto : Veiculo
    {
        public int Cilindrada { get; set; }

        public void Empinar()
        {
            Console.WriteLine($"Moto Empinando com cilindrada de {Cilindrada} cc");
        }
    }
}

