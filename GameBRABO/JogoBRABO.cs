using GameBRABO.Interface;

namespace GameBRABO{
    public class JogoBRABO{
        private readonly iJogador _jogadorA;
        private readonly iJogador _jogadorB;
        private readonly iJogador _jogadorC;
        private readonly iJogador _jogadorD;
        
        public JogoBRABO(iJogador jogadorA, iJogador jogadorB, iJogador jogadorC, iJogador jogadorD){
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
            _jogadorC = jogadorC;
            _jogadorD = jogadorD;
        }
        public void IniciarJogo(){
            System.Console.Write("\tRonaldo\n");
            //
            System.Console.Write(_jogadorA.Correr());
            System.Console.Write(_jogadorA.Chutar());
            System.Console.Write(_jogadorA.Passar());
            System.Console.Write(_jogadorA.Marcar());
            System.Console.Write(_jogadorA.Driblar());
            System.Console.Write(_jogadorA.Um_dois());
            // 
            System.Console.Write("\tEdmundo\n");
            // 
            System.Console.Write(_jogadorB.Correr());
            System.Console.Write(_jogadorB.Chutar());
            System.Console.Write(_jogadorB.Passar());
            System.Console.Write(_jogadorB.Dancar());
            System.Console.Write(_jogadorB.Marcar());
            System.Console.Write(_jogadorB.Driblar());
            System.Console.Write(_jogadorB.Um_dois());
            //
            System.Console.Write("\tMbappé\n");
            //
            System.Console.Write(_jogadorC.Correr());
            System.Console.Write(_jogadorC.Chutar());
            System.Console.Write(_jogadorC.Passar());
            System.Console.Write(_jogadorC.Marcar());
            System.Console.Write(_jogadorC.Driblar());
            System.Console.Write(_jogadorC.Um_dois());
            //
            System.Console.Write("\tZidane\n");
            //
            System.Console.Write(_jogadorD.Correr());
            System.Console.Write(_jogadorD.Chutar());
            System.Console.Write(_jogadorD.Passar());
            System.Console.Write(_jogadorD.Marcar());
            bool cabecada = true;
            if(cabecada){
                System.Console.Write(_jogadorD.Cabecada());
                System.Console.Write("e foi expulso do jogo.\n");
            }
            System.Console.Write(_jogadorD.Um_dois());           
            System.Console.Write(_jogadorD.Driblar());
        }
    }
}
