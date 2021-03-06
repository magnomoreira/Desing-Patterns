namespace Strategy
{
    public class ICCC : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000)
            {
                return orcamento.Valor * 0.5;
            }
            if (orcamento.Valor > 1000 && orcamento.Valor < 3000)
            {
                return orcamento.Valor * 0.07;
            }
            else
            {
                return orcamento.Valor * 0.08 + 30;
            }
        }
    }
}