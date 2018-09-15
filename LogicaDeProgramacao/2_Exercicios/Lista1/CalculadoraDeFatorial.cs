using System;

namespace LogicaDeProgramacao._2_Exercicios
{

    public class CalculadoraDeFatorial : IExercicio
    {
        public bool VerificarResposta()
        {
            return
                   Validar.SaoIguais(2, Rodar(2))
                && Validar.SaoIguais(5, Rodar(3))
                && Validar.SaoIguais(3628800, Rodar(10))
                && Validar.SaoIguais(3628800, Rodar(10))
                && Validar.SaoIguais(1, Rodar(0));
        }

        public float Rodar(int n)
        {
            throw new NotImplementedException();
        }
    }

}