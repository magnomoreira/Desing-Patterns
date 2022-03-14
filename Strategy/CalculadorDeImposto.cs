namespace Strategy
{
    public class CalculadorDeImposto
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            // Além de imprimir o resultado na tela, poderia retorna o status ou até mesmo mudar o status ou algo mais.
            // Portanto, essa class no nosso contexto atual não seria necessária, mas em um contexto um pouco maior seria de grande ultildade
            var response = imposto.Calcula(orcamento);
            Console.WriteLine(response);
        }
    }
}