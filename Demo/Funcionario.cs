using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class Funcionario : Pessoa
    {
        public Funcionario(string nome, double salario)
        {
            Nome = string.IsNullOrEmpty(nome) ? "Fulano" : nome;
            DefinirSalario(salario);
            DefinirNivelProfissionalComBaseNoSalario(salario);
            DefinirHabilidades();
        }

        private void DefinirSalario(in double salario)
        {
            if(salario < 500) throw new Exception("Salario inferior ao permitido");
            Salario = salario;
        }

         private void DefinirNivelProfissionalComBaseNoSalario(in double salario)
        {
            if(salario < 500) throw new Exception("Salario inferior ao permitido");

            if (salario < 2000) NivelProfissional = NivelProfissional.Junior;
            if (salario >= 2000 && salario < 8000) NivelProfissional = NivelProfissional.Pleno;
            if (salario >= 8000) NivelProfissional = NivelProfissional.Senior;
        }


        private void DefinirHabilidades()
        {
            var habilidades = new List<string>()
            {
                "Lógica de Programação",
                "POO"
            };

            Habilidades = habilidades;

            switch (NivelProfissional)
            {
                case NivelProfissional.Pleno:
                    Habilidades.Add("Testes");
                    break;

                case NivelProfissional.Senior:
                    Habilidades.Add("Testes");
                    Habilidades.Add("Microservices");
                    break;
            }
        }

       

        public double Salario { get; set; }
        public NivelProfissional NivelProfissional { get; set; }
        public IList<string> Habilidades { get; set; }
    }

    public enum NivelProfissional
    {
        Junior = 1,
        Pleno = 2,
        Senior = 3
    }

    public class FuncionarioFactory
    {
        public static Funcionario Criar(string nome, double salario)
        {
            return new Funcionario(nome, salario);
        }
    }
}
