using System;

namespace Exceptionsx
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3];

            try
            {
                // for (var index = 0; index < 10; index++)
                for (var index = 0; index < 3; index++)
                    Console.WriteLine(arr[index]);

                Cadastrar("");
            }
            catch (ArgumentNullException ex) //Tratar primeiro os erros mais especificos
            {
                Console.WriteLine("Falha ao cadastrar o texto!");
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex) //Tratar primeiro os erros mais especificos
            {
                Console.WriteLine("Índice inexistente na lista");
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ops, algo deu errado!");
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
            }
            finally //Sempre é executado. Aqui se usa fechar arquivos, conexão com BD, tratamentos.
            {
                Console.WriteLine("Chegou ao fim")
            }
        }

        static void Cadastrar(string text)
        {
            if (string.IsNullOrEmpty(text))
                // throw new Exception("O texto não pode ser nulo ou vazio");
                throw new ArgumentNullException("O texto não pode ser nulo ou vazio");
        }
    }
}