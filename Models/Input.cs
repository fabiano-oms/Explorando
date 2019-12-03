namespace Explorando.Models {
    public class Input {
        public int menu { get; set; } = 1;
        public char[] movimentosAlpha { get; set; }
        public char[] movimentosBeta { get; set; }
        public string posicaoFinalAlpha { get; set; }
        public string posicaoFinalBeta { get; set; }
    }
}