namespace calculadora {
    class Program {
        static double soma(double[] uni) {
            double resultado=0;
             foreach (var i in uni) {
                resultado += i ;}
             return resultado;
        }
        static double subtracao(double[] uni) {
            double numeros =0;
            foreach (var i in uni) {
                numeros -= i ;
            }
            return numeros;
        }
        static double mult(double[] uni) {
            double numeros = 1;
           foreach (var i in uni) {
                numeros *= i ;
            }
            return numeros;
        }

        
        static void Main(string[] args) {
            double[] numeros = { 1, 2, 3, 4, 5 };
            Console.WriteLine(soma(numeros));
        }
    }
}
