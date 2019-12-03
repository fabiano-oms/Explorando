using System;
using Explorando.Models;

namespace Explorando.Controllers {
    public class CodigoSondaController {

        //INSTANCIANDO OS MODELS
        SondaAlphaModel sondaAlpha = new SondaAlphaModel ();
        SondaBetaModel sondaBeta = new SondaBetaModel ();
        PlanaltoModel planalto = new PlanaltoModel ();
        Input _config = new Input ();

        public void EnviarComando () {
            Console.Clear ();
            PlanaltoMapa ();
            PosicaoInicialAlpha ();
            ComandoMovimentoAlpha ();
            ExecutarComandoAlpha ();
            PosicaoInicialBeta ();
            ComandoMovimentoBeta ();
            ExecutarComandoBeta ();
            Console.Clear();
            System.Console.WriteLine (_config.posicaoFinalAlpha);
            System.Console.WriteLine (_config.posicaoFinalBeta);
        }

        public void PlanaltoMapa () {
            System.Console.WriteLine (
                @"
                            Grid de exploração:"
            );
            System.Console.Write (
                @"          X: ");
            planalto.tamanhoX = int.Parse (Console.ReadLine ());
            System.Console.Write (
                @"          Y: ");
            planalto.tamanhoY = int.Parse (Console.ReadLine ());
        }

        public void PosicaoInicialAlpha () {
            System.Console.WriteLine (
                @"
                            Posição inicial da sonda Alpha:"
            );
            System.Console.Write (
                @"          X: ");
            sondaAlpha.posicaoX = int.Parse (Console.ReadLine ());
            System.Console.Write (
                @"          Y: ");
            sondaAlpha.posicaoY = int.Parse (Console.ReadLine ());
            System.Console.Write (
                @"          Direção: ");
            sondaAlpha.direcao = Console.ReadLine ().ToUpper ();

            sondaAlpha.iposicaoX = sondaAlpha.posicaoX;
            sondaAlpha.iposicaoY = sondaAlpha.posicaoY;
            sondaAlpha.idirecao = sondaAlpha.direcao;
        }

        public void PosicaoInicialBeta () {
            System.Console.WriteLine (
                @"
                            Posição inicial da sonda Beta:"
            );
            System.Console.Write (
                @"          X: ");
            sondaBeta.posicaoX = int.Parse (Console.ReadLine ());
            System.Console.Write (
                @"          Y: ");
            sondaBeta.posicaoY = int.Parse (Console.ReadLine ());
            System.Console.Write (
                @"          Direção: ");
            sondaBeta.direcao = Console.ReadLine ().ToUpper ();

            sondaBeta.iposicaoX = sondaBeta.posicaoX;
            sondaBeta.iposicaoY = sondaBeta.posicaoY;
            sondaBeta.idirecao = sondaBeta.direcao;
        }

        public void ComandoMovimentoAlpha () {
            System.Console.WriteLine (
                @"
                            Comandos de Movimentos da sonda Alpha:"
            );
            System.Console.Write (
                @"          Input: ");
            string comandosAlpha = Console.ReadLine ().ToUpper ();
            _config.movimentosAlpha = comandosAlpha.ToCharArray ();
        }

        public void ComandoMovimentoBeta () {
            System.Console.WriteLine (
                @"
                            Comandos de Movimento da sonda Beta:"
            );
            System.Console.Write (
                @"          Input: ");
            string comandosBeta = Console.ReadLine ().ToUpper ();
            _config.movimentosBeta = comandosBeta.ToCharArray ();
        }

        public void VirarParaDireitaA () {
            switch (sondaAlpha.direcao) {
                case "N":
                    sondaAlpha.direcao = "E";
                    break;
                case "E":
                    sondaAlpha.direcao = "S";
                    break;
                case "S":
                    sondaAlpha.direcao = "W";
                    break;
                case "W":
                    sondaAlpha.direcao = "N";
                    break;
                default:
                    System.Console.WriteLine ("Não foi possível executar o comando!");
                    break;
            }
        }

        public void VirarParaDireitaB () {
            switch (sondaBeta.direcao) {
                case "N":
                    sondaBeta.direcao = "E";
                    break;
                case "E":
                    sondaBeta.direcao = "S";
                    break;
                case "S":
                    sondaBeta.direcao = "W";
                    break;
                case "W":
                    sondaBeta.direcao = "N";
                    break;
                default:
                    System.Console.WriteLine ("Não foi possível executar o comando!");
                    break;
            }
        }

        public void VirarParaEsquerdaA () {
            switch (sondaAlpha.direcao) {
                case "N":
                    sondaAlpha.direcao = "W";
                    break;
                case "W":
                    sondaAlpha.direcao = "S";
                    break;
                case "S":
                    sondaAlpha.direcao = "E";
                    break;
                case "E":
                    sondaAlpha.direcao = "N";
                    break;
                default:
                    System.Console.WriteLine ("Não foi possível executar o comando!");
                    break;
            }
        }

        public void VirarParaEsquerdaB () {
            switch (sondaBeta.direcao) {
                case "N":
                    sondaBeta.direcao = "W";
                    break;
                case "W":
                    sondaBeta.direcao = "S";
                    break;
                case "S":
                    sondaBeta.direcao = "E";
                    break;
                case "E":
                    sondaBeta.direcao = "N";
                    break;
                default:
                    System.Console.WriteLine ("Não foi possível executar o comando!");
                    break;
            }
        }

        public void MoverSondaA () {
            switch (sondaAlpha.direcao) {
                case "N":
                    sondaAlpha.posicaoY += 1;
                    break;
                case "E":
                    sondaAlpha.posicaoX += 1;
                    break;
                case "S":
                    sondaAlpha.posicaoY -= 1;
                    break;
                case "W":
                    sondaAlpha.posicaoX -= 1;
                    break;
                default:
                    System.Console.WriteLine ("Não foi possível executar o comando!");
                    break;
            }
        }

        public void MoverSondaB () {
            switch (sondaBeta.direcao) {
                case "N":
                    sondaBeta.posicaoY += 1;
                    break;
                case "E":
                    sondaBeta.posicaoX += 1;
                    break;
                case "S":
                    sondaBeta.posicaoY -= 1;
                    break;
                case "W":
                    sondaBeta.posicaoX -= 1;
                    break;
                default:
                    System.Console.WriteLine ("Não foi possível executar o comando!");
                    break;
            }
        }

        public void ExecutarComandoAlpha () {
            for (int i = 0; i < _config.movimentosAlpha.Length; i++) {
                switch (_config.movimentosAlpha[i]) {
                    case 'M':
                        MoverSondaA ();
                        break;
                    case 'R':
                        VirarParaDireitaA ();
                        break;
                    case 'L':
                        VirarParaEsquerdaA ();
                        break;
                    default:
                        System.Console.WriteLine ("Não foi possível executar o comando!");
                        break;
                }
            }
            if ((sondaAlpha.posicaoX <= planalto.tamanhoX && sondaAlpha.posicaoX >= 0 ) && (sondaAlpha.posicaoY <= planalto.tamanhoY && sondaAlpha.posicaoY >= 0)){
                _config.posicaoFinalAlpha = $@"
                            Posição final da sonda Alpha:   {sondaAlpha.posicaoX.ToString()} {sondaAlpha.posicaoY.ToString()} {sondaAlpha.direcao.ToString()}";
            } else {
                _config.posicaoFinalAlpha = $@"
                            Comando não executado, devido ao limite do Grid [{planalto.tamanhoX},{planalto.tamanhoY}] a sonda Alpha permanece em sua posição inicial:   
                            Posição inicial da sonda Alpha: {sondaAlpha.iposicaoX.ToString()} {sondaAlpha.iposicaoY.ToString()} {sondaAlpha.idirecao.ToString()}";
            }
        }

        public void ExecutarComandoBeta () {
            for (int i = 0; i < _config.movimentosBeta.Length; i++) {
                switch (_config.movimentosBeta[i]) {
                    case 'M':
                        MoverSondaB ();
                        break;
                    case 'R':
                        VirarParaDireitaB ();
                        break;
                    case 'L':
                        VirarParaEsquerdaB ();
                        break;
                    default:
                        System.Console.WriteLine ("Não foi possível executar o comando!");
                        break;
                }
            }
            if ((sondaBeta.posicaoX <= planalto.tamanhoX && sondaBeta.posicaoX >= 0 ) && (sondaBeta.posicaoY <= planalto.tamanhoY && sondaBeta.posicaoY >= 0)){
                _config.posicaoFinalBeta = $@"
                            Posição final da sonda Beta:    {sondaBeta.posicaoX.ToString()} {sondaBeta.posicaoY.ToString()} {sondaBeta.direcao.ToString()}
                            ";
            } else {
                _config.posicaoFinalBeta = $@"
                            Comando não executado, devido ao limite do Grid [{planalto.tamanhoX},{planalto.tamanhoY}] a sonda Beta permanece em sua posição inicial:   
                            Posição inicial da sonda Beta:  {sondaBeta.iposicaoX.ToString()} {sondaBeta.iposicaoY.ToString()} {sondaBeta.idirecao.ToString()}
                            ";
            }
        }
    }
}