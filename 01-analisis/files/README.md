# parking-365

Software Parking 365

https://www.youtube.com/watch?v=TRr5WOMuBFg   OKS


--https://www.youtube.com/watch?v=5ExMStPWTcs
https://www.youtube.com/watch?v=6VdIEovint8
https://www.youtube.com/watch?v=J5c1vb5xqyo

si puede trabajar en red (con rasberry) con la PC donde va estar el software -> mejor control

no hay para hacer nada de eso -> 
se instala la barrera con la impresora.
presionan un boton.
genera un ticket con la hora de ingreso.
cuando el cliente se va.
paga a caja (cobra el tiempo que leyo)
la lectora lee el ticket y calcula el tiempo y lo tarifa.
despues de pagar se genera otro ticket (para salida, 15 minutos para salir)
lectora modulo de salida debe validar los 15 minutos si se pasa no deja salir.




SOFTWARE DE PARKING
Características del Software:
•	Método de cobro:
o	Por hora o fracción.
o	Hora o fracción, más tiempo de estancia más barato por hora
o	1ra hora un valor, y en adelante otro valor por hora fracción
o	Cobro por noches
o	Cobro con convenio: es decir la 1ra hora es gratis
o	Cobro con clientes mensuales: cada cliente mensual tiene un código, el cual tiene cierta cantidad de dinero abonado, cuando se acabe su saldo el software automáticamente le cobra de forma normal
•	El cliente tiene X minutos de gracia, es decir que a partir de 1 hora con X minutos se cobra de 2 horas (se puede modificar)
•	Se guarda en la base de datos:
o	Acumulado total del día
o	Número de tarjetas (equivalente al Nro. autos) que ingresaron
o	Total acumulado de convenio con empresas (en caso de requerir).
o	Total acumulado en pases gratuitos (usados con la tarjeta especial del dueño)
o	Total en clientes mensuales
•	Se imprime o exporta a Excel
o	Reporte del día o desde-hasta la fecha que se desee.
o	Reporte según usuario
o	Reporte según el tipo de cobro
•	La información de los reportes y de las tarjetas entregadas a los vehículos no se borra a pesar de falla eléctrica.
•	Precio en el recibo se puede incluir el IGV, por tanto la impresión del recibo puede ser documento legal (para esto se necesita papel pre impreso).
•	
•	opcion a integrar con control de acceso
•	Clientes mensuales, los clientes regulares pueden tener una tarjeta magnética o RFID que al ingresar y al salir deben presentarla y el software automáticamente le va descontado de su saldo además cada cliente se puede configurar para funcionar dentro de un horario establecido.
•	El software se puede instalar en cualquier computador con Windows XP o superior y con mínimo 2 puertos USB, en caso que requiera también el computador observe en la cotización el computador.


Funcionamiento con Barrera Vehicular y Dispensador de Tickets en la Entrada y Cobro Manual en la Salida
1.	Cuando entra un vehículo, presiona el botón en el dispensador de tickets y automáticamente imprimirá un ticket de papel térmico con un código de barras y abrirá la barrera de entrada.
2.	Cuando regrese a sacar el vehículo, se dirige a la caja donde el empleado escanea el ticket y el software calcula el valor a pagar e imprime el recibo, e inmediatamente da permiso para que salga el vehículo, este sistema se usa cuando la caja de pago se encuentra en el carril de salida y por tanto el empleado puede ver qué carro puede salir o no, por eso no se usa la barrera de salida.
 
Funcionamiento con Barrera Vehicular y Dispensador de Tickets en la Entrada y Escáner Externo y Barrera Vehicular en la Salida
1.	Cuando regrese a sacar el vehículo, se dirige a la caja donde el empleado escanea el ticket y el software calcula el valor a pagar e imprime el recibo.
2.	El cliente se dirige a la salida y presenta el ticket en el escáner externo, si ya canceló el ticket, se levanta la barrera de salida.



{"EGENERATE_IMAGE-2: Image size specified not large enough to draw image. (Bar size determined to be less than 1 pixel)"}
public Int32 Id { get; set; }
public String Ticket { get; set; }
public String Fecha { get; set; }
public String Hora { get; set; }
public String Placa { get; set; }
public String Puerta { get; set; }
public DateTime FeIngreso { get; set; }
public DateTime FeSalida { get; set; }
public String HoraSalida { get; set; }
public Int32 Tiempo { get; set; }
public Int32 Tarifa { get; set; }
public Decimal Costo { get; set; }


