public class televisao
{
    private const int VOL_MAX = 100; //CONSTANTE
    public televisao(float tamanho)
}
{
    public televisao(float tamanho)
    {
        Tamanho = tamanho;
    }


    public float Tamanho { get; set; }
    public int Resolucao { get; set; }
    public int Volume { get; private set; }
    public int Canal { get; set; }
    public bool Estado { get; set; }

    public void AumentarVolume()
    {
        if(Volume < VOL_MAX)
            Volume = Volume + 1;
        else 
            Console.WriteLine("TV já está no max.");
    }
}