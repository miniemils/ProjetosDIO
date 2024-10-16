namespace DesafioConsole.services
{
    public class ValidacoesLista
    {
        public List<int> RemoverNumerosNegativos(List<int> lista)
        {
            var novaLista = new List<int>();
            foreach(int num in lista)
            {
                if(num > 0)
                {
                    novaLista.Add(num); 
                }
            }
            return novaLista;
        }

        public bool ListaContemDeterminadoNumero(List<int> lista, int numero)
        {
            foreach(int num in lista)
            {
                if(num == numero)
                {
                   return true; 
                }
            }
            return false;
        }

        public List<int> MultiplicarNumerosDaLista(List<int> lista, int numero)
        {  
            var novaLista = new List<int>();
            foreach(int num in lista)
            {
                novaLista.Add(num * numero);
            }
            return novaLista;
        }

        public int MaiorNumeroDaLista(List<int> lista)
        {
            int maior = int.MinValue;
            foreach(int num in lista)
            {
                if(num > maior)
                {
                    maior = num;
                } 
            }
            return maior;
        }

        public int MenorNumeroDaLista(List<int> lista)
        {
            int menor = int.MaxValue;
            foreach(int num in lista)
            {
                if(num < menor)
                {
                    menor = num;
                } 
            }
            return menor;
        }
    }
}