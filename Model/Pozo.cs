namespace WebApp.Model;
public class Pozo
{
    public List<int> Produccion { get; set; }
    public float Precio { get; set; }
    public float Inversion { get; set; }
    public float VAN;
    private static readonly float TASA_DE_INTERES = 3f;
    public Pozo()
    {
        Produccion = new List<int>();
    }

    private int MesesDeInversion {get; set;}
    public void SetVAN()
    {
        VAN = 0f; 
        for(int i = 0; i < MesesDeInversion; i++)
        {
            float produccionMensual = (Produccion[i] * Precio) / (float)Math.Pow((1 + TASA_DE_INTERES), i);
            VAN += produccionMensual;
        }
        VAN -= Inversion;
    }    
}