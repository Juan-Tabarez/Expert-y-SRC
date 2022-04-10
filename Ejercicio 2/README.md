# Universidad Católica del Uruguay
<img src="https://ucu.edu.uy/sites/all/themes/univer/logo.png"> 

## Facultad de Ingeniería y Tecnologías
### Programación II

### Sistema de consultas médicas

Como desarrolladores de software, se nos pide hacer el mantenimiento de un sistema de gestión médica,
especifícamente se nos pide que hagamos mantenimiento de la funcionalidad de coordinación de consultas. Para ello debemos tener en cuenta que:
1. Se podrían agregar otros datos del paciente como por ejemplo su edad.
2. Se podrían agregar otros datos al Doctor como por ejemplo su especialidad.
3. La consulta debe tener un identificador único
4. Cada dato que se ingrese al sistema debe ser válidado.

Para el ejercicio se pide

#### ✍ Parte 1 
**Criticar el código dado en base a patrónes y principios**

Existe una única clase llamada "AppointmentService", que posee un método que crea consultas, utiliza datos pertenecientes a los pacientes y a los doctores. El problema de esto, es que una sola clase esta asumiendo varias responsabilidades a la vez por lo que sería una buena práctica crear nuevas clases, que cumplan con el patrón SRP. Ademas decidimos que era mejor idea validar los datos que se le pasaban a "AppointmentService" dentro 
de las clases expertas que conocen dichos datos. El codigo base era muy dificil de extender.

#### 🧐 Parte 2 
**Realizar las CRC correspondientes.**

#### 👩‍💻 Parte 3
**Aplique patrónes/principios según su crítica.**


//Existe una única clase llamada "Appointment service", que posee un constructor de consulta, que utiliza datos pertenecientes a los pacientes y a los doctores, el problema de esto, es que no existen otras clases expertas, con la responsabilidad de conocer estos datos. Por lo que sería una buena práctica crear dichas clases, que cumplan con el patrón SRP.