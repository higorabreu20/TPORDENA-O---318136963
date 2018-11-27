using System;
using System.Diagnostics;

class tpordenação
{
   
    static void Preencher(int[] vetor1, int[] vetor2, int[] vetor3)
    {

        for (int i = 0; i <= vetor1.Length - 1; i++)
        {

            vetor1[i] = i + 1;

        }
        for (int i = vetor2.Length - 1; i >= 0; i--)
        {
            vetor2[i] = i + 1;

        }

        for (int i = 0; i <= vetor3.Length - 1; i++)
        {
            vetor3[i] = RandomNumber(0, 100000);

        }
    }
    
    static void Imprime(int[] vetor1, int[] vetor2, int[] vetor3)
    {

        for (int i = 0; i <= vetor1.Length - 1; i++)
        {

            Console.WriteLine(vetor1[i]);

        }
        for (int i = 0; i <= vetor2.Length - 1; i++)
        {
            Console.WriteLine(vetor2[i]);

        }

        for (int i = 0; i <= vetor3.Length - 1; i++)
        {
            Console.WriteLine(vetor3[i]);

        }
    }

    public static void Main()
    {
        Console.BackgroundColor = ConsoleColor.Magenta;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Black;
        int[] vetor1;
        int[] vetor2;
        int[] vetor3;

        bool sair = false;
        do
        {
            Console.Write("tempo de ordenação\n" +
            "Iniciar [1] = BubbleSort\n" +
            "Iniciar [2] = InsertionSort\n" +
            "Iniciar [3] = SelectionSort\n" +
            "Iniciar [4] = MergeSort\n" +
            "Iniciar [5] = QuickSort\n" +
            "Insira apenas numero no menu:\n");

            Stopwatch timer = new Stopwatch();

            bool bubble = false;
            bool insertion = false;
            bool selection = false;
            bool merge = false;
            bool quick = false;

            var menu = Console.ReadKey();
            Console.WriteLine("\n");

            if (bubble = menu.KeyChar == '1')
            {
                vetor1 = new int[100000];
                vetor2 = new int[100000];
                vetor3 = new int[100000];
                Preencher(vetor1, vetor2, vetor3);

                timer.Start();
                bubbleSort(vetor1);
                timer.Stop();
                TimeSpan tempoBubble1 = timer.Elapsed;
                timer.Reset();

                timer.Start();
                bubbleSort(vetor2);
                timer.Stop();
                TimeSpan tempoBubble2 = timer.Elapsed;
                timer.Reset();

                timer.Start();
                bubbleSort(vetor3);
                timer.Stop();
                TimeSpan tempoBubble3 = timer.Elapsed;
                timer.Reset();





                

                Console.WriteLine("\nO tempo do Bubble Sort no vetor 1 foi: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoBubble1.Minutes, tempoBubble1.Seconds, tempoBubble1.Milliseconds);
                Console.WriteLine("\nO tempo do Bubble Sort no vetor 2 foi: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoBubble2.Minutes, tempoBubble2.Seconds, tempoBubble2.Milliseconds);
                Console.WriteLine("\nO tempo do Bubble Sort no vetor 3 foi: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoBubble3.Minutes, tempoBubble3.Seconds, tempoBubble3.Milliseconds);
                timer.Reset();
            }
            else if (insertion = menu.KeyChar == '2')
            {
                vetor1 = new int[100000];
                vetor2 = new int[100000];
                vetor3 = new int[100000];
                Preencher(vetor1, vetor2, vetor3);

                timer.Start();
                InsertionSort(vetor1);
                timer.Stop();
                TimeSpan tempoInsertion1 = timer.Elapsed;
                timer.Reset();


                timer.Start();
                InsertionSort(vetor2);
                timer.Stop();
                TimeSpan tempoInsertion2 = timer.Elapsed;
                timer.Reset();

                timer.Start();
                InsertionSort(vetor3);
                timer.Stop();

                TimeSpan tempoInsertion3 = timer.Elapsed;

                timer.Reset();

               


                Console.WriteLine("O tempo do Insertion Sort no vetor 1 foi: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoInsertion1.Minutes, tempoInsertion1.Seconds, tempoInsertion1.Milliseconds);
                Console.WriteLine("O tempo do Insertion Sort no vetor 2 foi: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoInsertion2.Minutes, tempoInsertion2.Seconds, tempoInsertion2.Milliseconds);
                Console.WriteLine("O tempo do Insertion Sort no vetor 3 foi: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoInsertion3.Minutes, tempoInsertion3.Seconds, tempoInsertion3.Milliseconds);

                timer.Reset();
            }
            else if (selection = menu.KeyChar == '3')
            {

                vetor1 = new int[100000];
                vetor2 = new int[100000];
                vetor3 = new int[100000];
                Preencher(vetor1, vetor2, vetor3);

                timer.Start();
                SelectionSort(vetor1);
                timer.Stop();
                TimeSpan tempoSelection1 = timer.Elapsed;
                timer.Reset();

                timer.Start();
                SelectionSort(vetor2);
                timer.Stop();
                TimeSpan tempoSelection2 = timer.Elapsed;
                timer.Reset();

                timer.Start();
                SelectionSort(vetor3);
                timer.Stop();
                TimeSpan tempoSelection3 = timer.Elapsed;
                timer.Reset();


               



                Console.WriteLine("O tempo do Selection Sort no vetor 1 foi: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoSelection1.Minutes, tempoSelection1.Seconds, tempoSelection1.Milliseconds);
                Console.WriteLine("O tempo do Selection Sort no vetor 2 foi: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoSelection2.Minutes, tempoSelection2.Seconds, tempoSelection2.Milliseconds);
                Console.WriteLine("O tempo do Selection Sort no vetor 3 foi: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoSelection3.Minutes, tempoSelection3.Seconds, tempoSelection3.Milliseconds);

                timer.Reset();
            }
            else if (merge = menu.KeyChar == '4')
            {

                vetor1 = new int[100000];
                vetor2 = new int[100000];
                vetor3 = new int[100000];
                Preencher(vetor1, vetor2, vetor3);

                timer.Start();
                MergeSort(vetor1, vetor1[0], vetor1.Length - 1);
                timer.Stop();
                TimeSpan tempoMerge1 = timer.Elapsed;
                timer.Reset();

                timer.Start();
                MergeSort(vetor2, vetor2[0], vetor2.Length - 1);
                timer.Stop();
                TimeSpan tempoMerge2 = timer.Elapsed;
                timer.Reset();

                timer.Start();
                MergeSort(vetor3, vetor3[0], vetor3.Length - 1);
                timer.Stop();
                TimeSpan tempoMerge3 = timer.Elapsed;
                timer.Reset();



                Console.WriteLine("O tempo do Merge Sort no vetor 1 foi: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoMerge1.Minutes, tempoMerge1.Seconds, tempoMerge1.Milliseconds);
                Console.WriteLine("O tempo do Merge Sort no vetor 2 foi: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoMerge2.Minutes, tempoMerge2.Seconds, tempoMerge2.Milliseconds);
                Console.WriteLine("O tempo do Merge Sort no vetor 3 foi: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoMerge3.Minutes, tempoMerge3.Seconds, tempoMerge3.Milliseconds);
                timer.Reset();
            }
            else if (quick = menu.KeyChar == '5')
            {

                vetor1 = new int[8100];
                vetor2 = new int[8100];
                vetor3 = new int[8100];
                Preencher(vetor1, vetor2, vetor3);

                timer.Start();
                QuickSort(vetor1);
                timer.Stop();
                TimeSpan tempoQuick1 = timer.Elapsed;
                timer.Reset();

                timer.Start();
                QuickSort(vetor2);
                timer.Stop();
                TimeSpan tempoQuick2 = timer.Elapsed;
                timer.Reset();

                timer.Start();
                QuickSort(vetor3);
                timer.Stop();
                TimeSpan tempoQuick3 = timer.Elapsed;


                

                
                Console.WriteLine("O tempo do Quick Sort no vetor 1 foi:  {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoQuick1.Minutes, tempoQuick1.Seconds, tempoQuick1.Milliseconds);
                Console.WriteLine("O tempo do Quick Sort no vetor 2 foi:  {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoQuick2.Minutes, tempoQuick2.Seconds, tempoQuick2.Milliseconds);
                Console.WriteLine("O tempo do Quick Sort no vetor 3 foi:  {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoQuick3.Minutes, tempoQuick3.Seconds, tempoQuick3.Milliseconds);
                timer.Reset();
            }
            else if (menu.KeyChar > 5)
                Console.WriteLine("Insira um numero do menu por favor;");

            Console.WriteLine("\n");
            Console.Write("Deseja Sair?:"
                        + "\n"
                        + "S = Sim."
                        + "\n"
                        + "N = Não.");
            var finalizar = Console.ReadKey();
            sair = finalizar.KeyChar == 'S' || finalizar.KeyChar == 's';
            Console.WriteLine("\n");
        } while (!sair);

        Console.ReadKey();
    }

    

    static int RandomNumber(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }

    

    static int[] bubbleSort(int[] vetor)
    {
        int i, j;
        int N = vetor.Length;

        for (j = N - 1; j > 0; j--)
        {
            for (i = 0; i < j; i++)
            {
                if (vetor[i] > vetor[i + 1])
                    TrocaBubble(vetor, i, i + 1);
            }
        }
        return vetor;
    }

    public static void TrocaBubble(int[] vetor, int i, int j)
    {
        int temp;

        temp = vetor[i];
        vetor[i] = vetor[j];
        vetor[j] = temp;
    }


    static int[] InsertionSort(int[] vetor)
    {
        for (int i = 0; i < vetor.Length - 1; i++)
        {
            int j = i + 1;

            while (j > 0)
            {
                if (vetor[j - 1] > vetor[j])
                {
                    int aux = vetor[j - 1];
                    vetor[j - 1] = vetor[j];
                    vetor[j] = aux;

                }
                j--;
            }
        }
        return vetor;
    }
    

    static int[] SelectionSort(int[] vetor)
    {

        int menor, i, j, aux;
        for (i = 0; i < vetor.Length - 1; i++)
        {
            
            menor = i;
            for (j = i; j < vetor.Length; j++)
            {
                
                if (vetor[j] < vetor[menor])
                    menor = j;
               
                aux = vetor[menor];
                
                vetor[menor] = vetor[i];
                
                vetor[i] = aux;
            }
        }
       
        return vetor;
    }

    
    public static int[] QuickSort(int[] vetor)
    {
        
        int inicio = 0;
        int fim = vetor.Length - 1;
       
        QuickSort(vetor, inicio, fim);

        return vetor;
    }
    

    private static void QuickSort(int[] vetor, int inicio, int fim)
    {
        if (inicio < fim)
        {
            int p = vetor[inicio];
            int i = inicio + 1;
            int f = fim;

            while (i <= f)
            {
                if (vetor[i] <= p)
                {
                    i++;
                }
                else if (p < vetor[f])
                {
                    f--;
                }
                else
                {
                    int troca = vetor[i];
                    vetor[i] = vetor[f];
                    vetor[f] = troca;
                    i++;
                    f--;
                }
            }

            vetor[inicio] = vetor[f];
            vetor[f] = p;

            QuickSort(vetor, inicio, f - 1);
            QuickSort(vetor, f + 1, fim);
        }
    }

    static void Merge(int[] input, int left, int middle, int right)
    {
        int[] leftArray = new int[middle - left + 1];
        int[] rightArray = new int[right - middle];

        Array.Copy(input, left, leftArray, 0, middle - left + 1);
        Array.Copy(input, middle + 1, rightArray, 0, right - middle);

        int i = 0;
        int j = 0;
        for (int k = left; k < right + 1; k++)
        {
            if (i == leftArray.Length)
            {
                input[k] = rightArray[j];
                j++;
            }
            else if (j == rightArray.Length)
            {
                input[k] = leftArray[i];
                i++;
            }
            else if (leftArray[i] <= rightArray[j])
            {
                input[k] = leftArray[i];
                i++;
            }
            else
            {
                input[k] = rightArray[j];
                j++;
            }
        }
    }

    static void MergeSort(int[] input, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;

            MergeSort(input, left, middle);
            MergeSort(input, middle + 1, right);

            Merge(input, left, middle, right);
        }
    }

}



