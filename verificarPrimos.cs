namespace verificarPrimos{
    public class VerificarPrimos{
        public bool EsPrimo(int resultado)
        {
             var numero1 = (int)Math.Floor(Math.Sqrt(resultado));

            for (int i = 2; i <= limit; ++i)  {
                if (resultado % i == 0)  return false;
        }

    }
    return false;
}

