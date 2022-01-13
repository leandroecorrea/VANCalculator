namespace WebApp.Model;
public class Pozo
{
    public List<int> Produccion { get; set; }
    public float Precio { get; set; }
    public float Inversion { get; set; }
    public float VAN => SetVAN();
    private static readonly float TASA_DE_INTERES = 3f;
    private int MesesDeInversion {get; set;}
    public float SetVAN()
    {
        float acum = 0f; 
        for(int i = 1; i < Produccion.Count + 1; i++)
        {
            float produccionMensual = (Produccion[i - 1] * Precio) / (float)Math.Pow((1 + TASA_DE_INTERES), i);
            acum += produccionMensual;
        }
        acum -= Inversion;
        return acum;
    }    
}