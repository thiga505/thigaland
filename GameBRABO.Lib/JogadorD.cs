using GameBRABO.Interface;

namespace GameBRABO.Lib{
    public class JogadorD : iJogador{
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
            return "Zidane deu uma cabeçada em um jogador, ";
        }
        public string Dancar(){
            return "";
        }
        public string Um_dois(){
            return "Zidane fez um dois com outro jogador.\n";
        }
        public string Driblar(){
            return "Zidane driblou um jogador.\n";
        }
        public string Carrinho(){
            return "Zidane deu um carrinho em um jogador.\n";
        }
    }
}