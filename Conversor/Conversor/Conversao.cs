using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    public class Conversao
    {
        public List<DePara> ListaDePara { get; set; }
        public Conversao()
        {
            ListaDePara = new List<DePara>();
            CarregarDadosBasicosConversao();
        }

        // Este método recebe um número arábico, efetua a conversão e retorna um número romano          
        public string ConverterParaRomano(int numero)
        {
            string numeroRomano = "";
            string numeroConvertido = "";

            // Converter o número natural para string para trabalhar no For dígito a dígito
            string numeroNatural = numero.ToString();
            int tamanhoDoNumero = numeroNatural.Length;

            // Este campo será usado para controla a separação dos números de 10 em 10. 
            // Ele será iniciado de 1. A atualização ocorrerá no final do for.
            int controleSeparacaoNumerica = 1;

            int numeroParcial = 0;

            for (int i = tamanhoDoNumero; i > 0; i--)
            {
                numeroConvertido = "";

                // Calcula o número parcial em relação a posição do número e multiplica para obter o número cheio, 
                // por exemplo, se estiver na 3 ocorrência o número será multiplicado por 100
                // Apurando com isso a dezena, centena e milhar.

                numeroParcial = Convert.ToInt16(numeroNatural.Substring(i - 1, 1)) * controleSeparacaoNumerica;

                if (numeroParcial > 0)
                {

                    
                    // Esta variável representará o último de-para da lista correspondente ao número a ser convertido. 

                    var dePara = new DePara();

                    // Esta variável conterá o número romano correspondente que pode ser dobrado. Exemplo o I para o número 3, o X para o número 30.
                    var algarismoRomanoAcumular = "";

                    // Esta variável conterá o número romano que deverá ser concatenado para apurar os números próximos aos campos da tabela de conversão.
                    // Por exemplo, neste campo terá o V para concatener com o I para apurar o 6 ou o 4.
                    var algarismoRomanoConcatenar = "";
                    var algarismoNumerico = 0;

                    // Este for busca o depara a ser efetuado e os campos para dobrar e concatenar.
                    foreach (var conversao in ListaDePara)
                    {
                        if (conversao.NumeroArabico > numeroParcial)
                            break;
                        dePara = conversao;
                        if (conversao.NumeroArabico < numeroParcial)
                        {
                            if (conversao.PermiteDobrar == "S")
                            {
                                algarismoRomanoAcumular = conversao.NumeroRomano;
                            }
                            algarismoNumerico = conversao.NumeroArabico;
                            algarismoRomanoConcatenar = conversao.NumeroRomano;
                        }
                    }

  
                    // Verifica se o número já existe na tabela de-para (ultimo registro) e pode ser convertido diretamente
                    if (numeroParcial == (dePara.NumeroArabico))
                    {
                        numeroConvertido = dePara.NumeroRomano;
                    }
                    else
                    {
                        numeroConvertido = "";
                                                
                        // Calcula o número de repetições
                        // Numero parcial dividido pelo controleseparacaonumerica (este controle será 1, 10, 100 ou seja é multiplicado por 10 a cada repetição 
                        // para que o campo final sempre esteja entre 1 a 3
                        // É subtraído a base do próximo número menor que o número que está sendo analisado.

                        int final = (numeroParcial / controleSeparacaoNumerica) - (algarismoNumerico / controleSeparacaoNumerica);

                        // Verifica se o número é exatamento um conjunto (1, 10, 100) do próximo número arábico (romando). Pois, se for
                        // é necessário concatenar o algarismoromandoacumular com o próximo número romano.

                        var proximoRomano2 = ListaDePara.Where(x => x.NumeroArabico == (numeroParcial + (1 * controleSeparacaoNumerica))).FirstOrDefault();
                        if (proximoRomano2 != null)
                        {
                            numeroConvertido = algarismoRomanoAcumular + proximoRomano2.NumeroRomano;
                        }
                        else
                        {
                            if (final > 3)
                                final = 3;

                            // Efetua o acumular do números romanos.
                            for (int j = 1; j <= final; j++)
                            {
                                numeroConvertido = numeroConvertido + algarismoRomanoAcumular;
                            }
                            numeroConvertido = algarismoRomanoConcatenar + numeroConvertido;
                        }
                    }
                         
                }

                numeroRomano = numeroConvertido + numeroRomano;
                controleSeparacaoNumerica = controleSeparacaoNumerica * 10; 
            }
             

            return numeroRomano;
        }

        // Este método carrega a base para os de-para entre os número arábicos e romanos. 
        // Este método é acionado na classe construtor. 
        // Ou seja, sempre que a classe Conversao for criada o método será acionado para disponibilizar o de para para ser trabalhado na conversão dos números
        private void CarregarDadosBasicosConversao()
        {
            DePara dePara = new DePara();
            // Número 1
            dePara.NumeroArabico = 1;
            dePara.NumeroRomano = "I";
            dePara.PermiteDobrar = "S";
            ListaDePara.Add(dePara);

            dePara = new DePara();
            // Número 5
            dePara.NumeroArabico = 5;
            dePara.NumeroRomano = "V";
            dePara.PermiteDobrar = "N";
            ListaDePara.Add(dePara);

            dePara = new DePara();
            // Número 10
            dePara.NumeroArabico = 10;
            dePara.NumeroRomano = "X";
            dePara.PermiteDobrar = "S";
            ListaDePara.Add(dePara);

            dePara = new DePara();
            // Número 50
            dePara.NumeroArabico = 50;
            dePara.NumeroRomano = "L";
            dePara.PermiteDobrar = "N";
            ListaDePara.Add(dePara);

            dePara = new DePara();
            // Número 100
            dePara.NumeroArabico = 100;
            dePara.NumeroRomano = "C";
            dePara.PermiteDobrar = "S";
            ListaDePara.Add(dePara);

            dePara = new DePara();
            // Número 500
            dePara.NumeroArabico = 500;
            dePara.NumeroRomano = "D";
            dePara.PermiteDobrar = "N";
            ListaDePara.Add(dePara);

            dePara = new DePara();
            // Número 1000
            dePara.NumeroArabico = 1000;
            dePara.NumeroRomano = "M";
            dePara.PermiteDobrar = "S";
            ListaDePara.Add(dePara); 
        }

    }

    public class DePara
    {
        // Número Arábico 
        public int NumeroArabico { get; set; }
        // Número romano correspondente ao número arábico
        public string NumeroRomano { get; set; }
        // Este campo indica se o algarismo Romano (NumeroRomano) permite dobrar para formar um número, exemplo 3 - III, 30 - XXX -
        public string PermiteDobrar { get; set; }

    }
}
