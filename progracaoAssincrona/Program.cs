using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progracaoAssincrona
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Tecle algo para iniciar...\n");
            Console.ReadKey();

            // signifca que essa tarefa deve ser concluida pra continuar o processamento da metodod principal,
            // ou seja pra continuar a execução dos comando depois do metodo "aguardar"
           await  aguardar(5);

            NewMethod();
        }

        private static void NewMethod()
        {
            Console.WriteLine("Ja passou 5 segunsos ...\n");
            Console.WriteLine("fim edi ");
            Console.ReadLine();
        }

        private static async Task aguardar(int tempo)
        {
            Console.WriteLine("Iniciando a espera...");
            await Task.Delay(TimeSpan.FromSeconds(tempo));
            Console.WriteLine("Fim da espera");
        }
    }
}
