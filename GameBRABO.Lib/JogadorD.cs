using GameBRABO.Interface;

namespace GameBRABO.Lib{
    public class JogadorD : iJogador {
        public string Chutar(){
            return "Zidane chutou a bola.\n";
        }
        public string Correr(){
            return "Zidane está correndo.\n";
        }
        public string Passar(){
            return "Zidane fez um passe.\n";
        }
        public string Marcar(){
            return "Zidane marcou o passe.\n";
        }
        public string Cabecada(){
            return "Zidane deu uma cabeçada em um jogador.\n";
        }
        public string Dancar(){
            throw new System.NotImplementedException();
        }
    }
}