using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppAula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listaEstudantes = new List<Estudante>();

            var x = new Estudante()
            {
                Id = 1,
                Nome = "Maria",
                Matricula = ""
            };

            var y = new Estudante()
            {
                Id = 2,
                Nome = "Edu",
                Matricula = ""
            };

            var z = new Estudante()
            {
                Id = 3,
                Nome = "Caio",
                Matricula = ""
            };

            listaEstudantes.Add(x);
            listaEstudantes.Add(y);
            listaEstudantes.Add(z);
            
            
            //EXIBIR estudante com id >= 2 ????


            //Console.WriteLine("Minha lista contem: ");
            //Console.WriteLine(listaEstudantes.Count);

            //var novaLista = listaEstudantes.Where(x => x.Nome.Contains("a")).ToList();

            //foreach (var estudante in novaLista)
            //{
            //    if (estudante.Nome.Contains("a"))
            //    {
            //        Console.WriteLine(estudante.Nome);
            //    }
            //}

            //Dictionary<string, string> openWith = new Dictionary<string, string>();
            //openWith.Add("txt", "notepad.exe");
            //openWith.Add("bmp", "paint.exe");
            //openWith.Add("dib", "paint.exe");

            // HTTPS;
            // HEADER - KEY - VALUE;//b

            //foreach (var item in openWith)
            //{
            //    Console.WriteLine($"Dictionary Key {item.Key} Value {item.Value}");
            //}

            //var aux = openWith.Where(x => x.Key.Contains("b")).ToList();

            //Console.WriteLine("======");

            //foreach (var item in aux)
            //{
            //    Console.WriteLine($"Dictionary Key {item.Key} Value {item.Value}");
            //}

            // List
            //ArrayList myAL = new ArrayList();
            //myAL.Add("Hello");
            //myAL.Add("World");
            //myAL.Add(123);
            //myAL.Add("!");


            //foreach (Object obj in myAL)// API - RESULT SUCESSO OBJ 1 OU ERRO OBJ 2 
            //    Console.Write("   {0}", obj);

        }
    }

    public class Estudante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
    }
}
