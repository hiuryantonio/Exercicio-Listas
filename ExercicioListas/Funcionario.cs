using System.Globalization;

namespace ExercicioListas
{
    class Funcionario
    {
        public int Id { get; conjunto; }
        nome da corda pública { obter; conjunto; }
        salário duplo público { obter;  conjunto privado;
    }

    Funcionáriopúblico(int id, nome da corda , salário duplo)
    {
        Id = id;
        Nome = nome;
        Salário = salário;
    }

    vazio público Aumentosalary(percentual duplo)
    {
        Salário += Salário * percentual / 100. 0;
    }

    público substituir corda ToString()
    {
        ID de retorno
            + ", disse.
            + Nome
            + ", disse.
            + Salário.ToString("F2", CultureInfo.Cultura Invariante);
    }
}

