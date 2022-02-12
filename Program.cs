using System;

namespace FundamentosCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //conversão implícita
            float valor = 25.8f;
            int outro = 25;

            valor = outro; // conversão implícita
            // *********************************************


            /*todas as conversões abaixo trazem um risco,
              só será detectado o erro em tempo de execução. */

            // conversão explícita
            int inteiro = 100;
            uint inteiroSemSinal = (uint)inteiro; // conversão explícita
            // *********************************************

            // Parse
            int inteiroParse = int.Parse("100"); // Parse - sempre espera uma string
            // *********************************************

            // Convert
            int inteiroConvert = Convert.ToInt32("100"); // Convert
            // *********************************************

            var nome = RetornaNome("Jeremias", "Deodato");
            Console.WriteLine(nome);


        }

        static string RetornaNome(string nome,
            string sobrenome,
            int idade = 35)// parametro opcional sermpre deve ser adicionado por último e não é obrigatório na chamada.
        {
            return nome + " " + sobrenome + " tem " + idade.ToString() + " anos de idade.";
        }
    }
}
