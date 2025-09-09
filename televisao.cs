public class Televisao
{
    private const int VOL_MAX = 100; // CONSTANTE
    private int CANAL_ANTES_DESLIGAR = 0;
    private const int CAN_MAX = 520; // CONSTANTE

    public Televisao(float tamanho)
    {
        Tamanho = tamanho;
    }
    
    public float Tamanho { get;}
    public int Resolucao { get; set;}
    public int Volume { get; private set;}
    public int Canal { get; set;}
    public bool Estado { get; set;}

    public void AumentarVolume()
    {
        if (Volume < VOL_MAX)
            Volume = Volume + 1;   
        else
            Console.WriteLine("TV já está no máximo.");
    }

    public void DiminuirVolume()
    {
        if (Volume > 0)
            Volume--;
        else
            Console.WriteLine("TV já está no mínimo.");
    }

    public void LigarTV()
    {
        Estado = true;
        Canal = CANAL_ANTES_DESLIGAR;
    }

    public void DesligarTV()
    {
        Estado = false;
        CANAL_ANTES_DESLIGAR = Canal;
    }

    

    public void AumentarCanal()
    {
        if (Canal < CAN_MAX)
            Canal++;   
        else
            Console.WriteLine("O canal não existe.");
    }

    public void DiminuirCanal()
    {
        if (Canal > 1)
            Canal--;
        else
            Console.WriteLine("Canal inexistente.");
    }

    public void CanalEspecifico(int CanalDesejado)
    {
        if (CanalDesejado < 1 || CanalDesejado > 520)
            Console.WriteLine("Erro.");
        else
            Canal = CanalDesejado;
    } 

}