namespace GameBRABO.Interface{
    public interface iJogador : iAtaque, iDefesa, iMisc{
         string Correr();
         string Chutar();
         string Passar();
    }
}