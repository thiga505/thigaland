using GameBRABO.Lib;

namespace GameBRABO{
    class Program{
        static void Main(string[] args){
            var jogo = new JogoBRABO(
                new JogadorA(),
                new JogadorB(),
                new JogadorC(),
                new JogadorD()
                );
                
            jogo.IniciarJogo();
        }
    }
}
