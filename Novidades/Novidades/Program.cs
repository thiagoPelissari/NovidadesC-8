using System;

namespace Novidades
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Hello World!");

            #region C#8
            //1*************RANGE INDEX
            //string[] cursos = new string[] { "asp.net", "C#", "Angular", "Java" };
            //foreach (var item in cursos[1..^1])
            //{
            //    Console.WriteLine($"{item}");
            //}



            //2*************FUNÇÕES LOCAIS ESTATICAS
            //Console.WriteLine(Soma(5, 5));
            //static int Soma(int a, int b) => a + b;




            //3*************SWITCH
            //var operador = "FX";
            //var resultado = operador switch
            //{
            //    "-" => "Subtrair",
            //    "+" => "Adição",
            //    "x" => "multiplicação",
            //    _ => "Operação desconhecida"
            //};
            //Console.WriteLine(resultado);




            //4************switch com tuplas
            //Console.WriteLine(RecuperaResultado((Resultado.Positivo, Resultado.Positivo), false));






            //5************USINGS
            //using var file = new System.IO.StreamWriter("file.txt");
            //using(var file2 = new System.IO.StreamWriter("asdas.ttxt"))
            //{
            //    file2.
            //}


            #endregion


            #region BÔNUS
            //*****************BÔNUS

            //6*****************COALESCE C#3.0
            //int? numero = null;
            //int numero2 = 0;
            //numero2 = numero ?? -1;

            //////FORMA ANTIGA
            //////if (numero != null)
            //////{
            //////    numero2 = numero.Value;
            //////}
            //////else
            //////{
            //////    numero2 = -1;
            //////}
            //Console.WriteLine(numero2);



            //7*****************NULL CONDITIONAL C#6
            //dynamic pessoa = new
            //{
            //    Cabeca = "grande",
            //    Mao = "Pequena",
            //    Pes = "Medios",
            //};

            ////if (pessoa.Cabeca == "grande")
            ////{
            ////    Console.WriteLine("Cabeçudo");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Cabeça normal");
            ////}

            //pessoa = null;

            //if (pessoa?.Cabeca == "grande")
            //{
            //    Console.WriteLine("Cabeçudo");
            //}
            //else
            //{
            //    Console.WriteLine("Cabeça normal");
            //}




            //8*************************DESCARTES
            var (nome, sobrenome) = RetornaNomeSobrenome();
            Console.WriteLine($"{nome} {sobrenome}");

            var (nome2, _) = RetornaNomeSobrenome();
            Console.WriteLine($"{nome2}");

            #endregion
        }

        public static (string, string) RetornaNomeSobrenome()
        {
            return ("Thiago", "Pellizzari");
        }

        public static Resultado RecuperaResultado((Resultado, Resultado) result, bool perigo = false)
        {
            return result switch
            {
                (Resultado.Positivo, Resultado.Positivo) when perigo => Resultado.Negativo,
                (Resultado.Positivo, Resultado.Positivo) when !perigo => Resultado.Positivo,
                (_,_) => Resultado.Negativo
            };
        }

        public enum Resultado
        {
            Positivo,
            Negativo
        }

    }
}
