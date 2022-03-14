using Strategy;

var Iss = new ISS();
var Icms = new ICMS();
var orcamento = new Orcamento(500.00);
var calculo = new CalculadorDeImposto();
calculo.RealizaCalculo(orcamento, Iss);
