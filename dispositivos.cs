using system;
namespace aporte
{
    public class dispositivos
    {

    public int IMEI{set;get;}
    public string marca{set;get;}
    public string modelo{set;get}
    public string sistema operativo {set;get}
    public string fabricacion{set; get;}
    public string hardware{set;get;}
    public string funcionalidad1{set;get}
    public string funcionalidad2{set;get;}
    public string funcionalidad3{set;get;}
    {
        public dispositivos {int IMEI, string marca, string modelo, string sistema operativo, string fabricacion, string hardware, string funcionalidad1, string funcionalidad2, string funcionalidad3}
        {
            this.IMEI=IMEI;
            this.marca=marca;
            this.modelo=modelo;
            this.sistemas operativo=sistema operativo;
            this.fabricacion=fabricacion;
            this.hardware=hardware;
            this.funcionalidad1=funcionalidad1;
            this.funcionalidad2=funcionalidad2;
            this.funcionalidad3=funcionalidad3;
        }
        public void imprimir  ();
        public void funcionalidades();
    }
}
]