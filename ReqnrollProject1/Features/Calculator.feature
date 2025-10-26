Feature: Calculator

Como enfermera/o
Quiero poder registrar los signos vitales y motivo de la consulta
Para un nivel de triaje

Background: 
Given que estan cargados al sistema los siguientes enfermeros:
| Nombre | Apellido | Cuil          |
| Ana    | Andinok  | 27-20345678-8 |

@tag1
Scenario: Ver en pantalla la historia del paciente
	Given que estan registrado al sistema los siguientes pacientes:
	| Nombre | Apellido | Cuil          |
	| Guido  | Kaczka   | 20-25123456-3 |
	When se ingresa el siguiente cuil:
	| Cuil          |
	| 20-25123456-3 |
	Then se muestra por los datos del paciente:
	| Nombre | Apellido | Cuil          | Consulta                 | Fecha de consulta |
	| Guido  | Kaczka   | 20-25123456-3 | Dolor en la zona pélvica | 12/10/2025        |

@tag2
Scenario: Ver los pacientes pendientes de evaluar
	Given que estan registrado al sistema los siguientes pacientes:
	| Nombre | Apellido | Cuil          |
	| Guido  | Kaczka   | 20-25123456-3 |
	| Analía | Ruberta  | 23-22999999-8 |
	When se ingresa el siguiente cuil:
	| Cuil          |
	| 20-25123456-3 |
	| 23-22999999-8 |
	Then se muestra los pacientes en espera de la siguiente manera:
	| Nombre | Apellido | Cuil          |
	| Analía | Ruberta  | 23-22999999-8 |