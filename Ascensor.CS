/* Ejercicio elevator

Usted ha sido contratado para escribir el software de un elevador, cuyas funciones principales consisten en subir y bajar pisos seleccionados 
por una persona. Al llegar al piso requerido, el elevador se detiene y la puerta se abre. Para continuar al siguiente piso requerido, la puerta 
se cierra y el elevador continúa. Un elevador no puede subir o bajar si la puerta está abierta. El elevador debe indicar por cual piso va cuando 
se encuentra en operación.

Todo elevador tiene un piso inicial y un piso tope. Los elevadores no pueden ir más allá de su piso tope. Los elevadores de este ejercicio son de 
la marca ELEVATORWELL.

ELEVATORWELL incluye funcionalidades de encendido y apagado automático. Para este ejercicio, se apagará automáticamente en las noches y de igual 
forma encenderá en las mañanas. Cada vez que ELEVATORWELL se enciende, se dirige al piso inicial, abre la puerta y despliega el mensaje 
“Bienvenido a ELEVATORWELL. Póngase cómodo y seleccione un piso hacia donde quiere ir”.
*/

using System;

class ELEVATORWELL{
    //Declaracion de los atributos de la clase

    private string SubirBajar;
    private int SeleccionarPiso;
    private string EstadoPuerta;
    private string EstadoAscensor;
    private int IngresarHora;
    private bool funcionamiento;

    //Declaracion de los metodos de la clase

    public void setSubirBajar(string SubirBajar){
        SubirBajar = SubirBajar.ToLower();
        //Console.WriteLine("Si desea subir, presiose la letra s, o si desea bajar, presione la letra b");
        if (SubirBajar.Equals("s") || SubirBajar.Equals("b")){
            this.SubirBajar = SubirBajar;
            } else {Console.WriteLine("Letra ingresada es invalida");
            } 
        }

    public int getSeleccionarPiso(){
        return this.SeleccionarPiso;
    }

    public void setSeleccionarPiso(int SeleccionarPiso){
        if (SeleccionarPiso >= -3 && SeleccionarPiso <=10 && SeleccionarPiso != 0){
            this.SeleccionarPiso = SeleccionarPiso;
        } else {
            Console.WriteLine("Error, piso ingresado es invalido");
        }
    }
    
    public string getEstadoPuerta(){
        return this.EstadoPuerta;

    }

    public void setEstadoPuerta(string estado){
        estado = estado.ToLower();

        if (estado.Equals("abierta") || estado.Equals("cerrada")){
            this.EstadoPuerta = estado;
        } else {
            Console.WriteLine("Error, Puerta debe estar abierta o cerrada");
        }
    }

    public string getEstadoAscensor(){
        return EstadoAscensor;
    }

    public void setEstadoAscensor(int hora, string Estado){
        hora = this.IngresarHora;
        if ((hora >= 19 && hora <= 23) && (hora >=0 && hora <=5)){
            Estado = "Apagado";
            Console.WriteLine("El ascensor esta apagado");
            if (hora >=6 && hora <=18){
                Estado = "Encendido";
                Console.WriteLine("El ascensor esta encendido");
                } else {
                    Console.WriteLine("Ingrese una hora valida");
                }
        }
        this.EstadoAscensor = Estado;
    }

    public int getIngresarHora(){
        return this.IngresarHora;
    }

    public void setIngresarHora(int hora){
        if (hora >=0 && hora <=23 ){
            this.IngresarHora = hora;
        } else {
            Console.WriteLine("Error, hora invalida ingrese una hora entre las 0 y 23");
        } 
    }
    public bool getfuncionamiento(){   
        return this.funcionamiento;

    }

    public void setfuncionamiento(string SubirBajar, string estado, bool funcionamiento){
        estado = this.EstadoPuerta;
        SubirBajar = this.SubirBajar;

        if ((SubirBajar.Equals("s") || SubirBajar.Equals("b")) && estado.Equals("abierta")){
            Console.WriteLine("Error, ascensor no puede subir/bajar con la puerta abierta, por favor cierre la puerta");
            } else {
                funcionamiento = true;
                this.funcionamiento = funcionamiento;
            }
    }
    public void DesplegarInformacion(){
        Console.WriteLine("\t\nBienvenido a ELEVATORWELL. Póngase cómodo y seleccione un piso hacia donde quiere ir");
        Console.WriteLine("Usted ha seleccionado que va hacia el piso: " + getSeleccionarPiso());
        Console.WriteLine("El ascensor esta" + getEstadoAscensor());
    }
}

public class AscensorTest{
    static void Main(){
        ELEVATORWELL Ascensor = new ELEVATORWELL();

        Ascensor.setSubirBajar("S");
        Ascensor.setSeleccionarPiso(7);
        Ascensor.setEstadoPuerta("cerrada");
        Ascensor.setIngresarHora(12);
        Ascensor.DesplegarInformacion();
    }
}
