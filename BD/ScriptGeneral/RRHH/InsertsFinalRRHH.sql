/*Mantenimientos*/
INSERT INTO `` (`pkId`,`fkIdModulo`,`nombre`,`estado`,`rutaChm`,`rutaHtml`) VALUES ('5001','5','MDI',1,'','');
INSERT INTO `` (`pkId`,`fkIdModulo`,`nombre`,`estado`,`rutaChm`,`rutaHtml`) VALUES ('5002','5','Mantenimiento Empleado',1,'C:\\Users\\RM\\Desktop\\final\\ProyectoHSC22021\\Ayuda\\RRHH\\5002\\Ayuda5002.chm','C:\\Users\\RM\\Desktop\\final\\ProyectoHSC22021\\Ayuda\\RRHH\\5002\\Ayuda5002.html');
INSERT INTO `` (`pkId`,`fkIdModulo`,`nombre`,`estado`,`rutaChm`,`rutaHtml`) VALUES ('5003','5','Mantenimiento Puesto',1,'C:\\Users\\RM\\Desktop\\final\\ProyectoHSC22021\\Ayuda\\RRHH\\5003\\Ayuda5003.chm','C:\\Users\\RM\\Desktop\\final\\ProyectoHSC22021\\Ayuda\\RRHH\\5003\\Ayuda5003.html');
INSERT INTO `` (`pkId`,`fkIdModulo`,`nombre`,`estado`,`rutaChm`,`rutaHtml`) VALUES ('5004','5','Mantenimiento Dias Trabajados',1,'C:\\Users\\RM\\Desktop\\final\\ProyectoHSC22021\\Ayuda\\RRHH\\5004\\Ayuda5004.chm','C:\\Users\\RM\\Desktop\\final\\ProyectoHSC22021\\Ayuda\\RRHH\\5004\\Ayuda5004.html');
INSERT INTO `` (`pkId`,`fkIdModulo`,`nombre`,`estado`,`rutaChm`,`rutaHtml`) VALUES ('5005','5','Mantenimiento Prestaciones Laborales',1,'C:\\Users\\RM\\Desktop\\final\\ProyectoHSC22021\\Ayuda\\RRHH\\5005\\Ayuda5005.chm','C:\\Users\\RM\\Desktop\\final\\ProyectoHSC22021\\Ayuda\\RRHH\\5005\\Ayuda5005.html');
INSERT INTO `` (`pkId`,`fkIdModulo`,`nombre`,`estado`,`rutaChm`,`rutaHtml`) VALUES ('5006','5','Mantenimiento Desarrollo de Carrera',1,'C:\\Users\\RM\\Desktop\\final\\ProyectoHSC22021\\Ayuda\\RRHH\\5006\\Ayuda5006.chm','C:\\Users\\RM\\Desktop\\final\\ProyectoHSC22021\\Ayuda\\RRHH\\5006\\Ayuda5006.html');
INSERT INTO `` (`pkId`,`fkIdModulo`,`nombre`,`estado`,`rutaChm`,`rutaHtml`) VALUES ('5200','5','Nómina',1,'','');
INSERT INTO `` (`pkId`,`fkIdModulo`,`nombre`,`estado`,`rutaChm`,`rutaHtml`) VALUES ('5300','5','Cierre de Nóminas',1,'','');

INSERT INTO `` (`fkIdUsuario`,`fkIdAplicacion`,`permisoEscritura`,`permisoLectura`,`permisoModificar`,`permisoEliminar`,`permisoImprimir`) VALUES ('1','5001',1,1,1,1,1);
INSERT INTO `` (`fkIdUsuario`,`fkIdAplicacion`,`permisoEscritura`,`permisoLectura`,`permisoModificar`,`permisoEliminar`,`permisoImprimir`) VALUES ('1','5002',1,1,1,1,1);
INSERT INTO `` (`fkIdUsuario`,`fkIdAplicacion`,`permisoEscritura`,`permisoLectura`,`permisoModificar`,`permisoEliminar`,`permisoImprimir`) VALUES ('1','5004',1,1,1,1,1);
INSERT INTO `` (`fkIdUsuario`,`fkIdAplicacion`,`permisoEscritura`,`permisoLectura`,`permisoModificar`,`permisoEliminar`,`permisoImprimir`) VALUES ('1','5003',1,1,1,1,1);
INSERT INTO `` (`fkIdUsuario`,`fkIdAplicacion`,`permisoEscritura`,`permisoLectura`,`permisoModificar`,`permisoEliminar`,`permisoImprimir`) VALUES ('1','5005',1,1,1,1,1);
INSERT INTO `` (`fkIdUsuario`,`fkIdAplicacion`,`permisoEscritura`,`permisoLectura`,`permisoModificar`,`permisoEliminar`,`permisoImprimir`) VALUES ('1','5006',1,1,1,1,1);

INSERT INTO `` (`idReporte`,`nombre`,`ruta`,`idAplicacion`,`estado`) VALUES ('2','5002','C:\\Users\\RM\\Desktop\\final\\ProyectoHSC22021\\Reportes\\RRHH\\reporteEmpleado.rpt','5002','A');
INSERT INTO `` (`idReporte`,`nombre`,`ruta`,`idAplicacion`,`estado`) VALUES ('3','5003','C:\\Users\\RM\\Desktop\\final\\ProyectoHSC22021\\Reportes\\RRHH\\reportePuesto.rpt','5003','A');
INSERT INTO `` (`idReporte`,`nombre`,`ruta`,`idAplicacion`,`estado`) VALUES ('4','5004','C:\\Users\\RM\\Desktop\\final\\ProyectoHSC22021\\Reportes\\RRHH\\reporteDiasTrabajados.rpt','5004','A');
INSERT INTO `` (`idReporte`,`nombre`,`ruta`,`idAplicacion`,`estado`) VALUES ('5','5005','C:\\Users\\RM\\Desktop\\final\\ProyectoHSC22021\\Reportes\\RRHH\\reportePrestacionesLaborales.rpt','5005','A');
INSERT INTO `` (`idReporte`,`nombre`,`ruta`,`idAplicacion`,`estado`) VALUES ('6','5006','C:\\Users\\RM\\Desktop\\final\\ProyectoHSC22021\\Reportes\\RRHH\\reporteDesarrolloDeCarrera.rpt','5006','A');

ALTER TABLE prestacionlaboral  ADD estado varchar(40) NOT NULL;  
ALTER TABLE diaslaborados ADD estado varchar(40) NOT NULL;  
ALTER TABLE puesto ADD estado varchar(40) NOT NULL; 
ALTER TABLE desarrollodecarrera ADD estado varchar(40) NOT NULL;   

/*Nominas*/
CREATE VIEW empleadoNomina AS
SELECT A.pkIdEmpleado, CONCAT(A.nombre, ' ', A.apellido) AS empleado, A.sueldo, B.año AS anio, B.enero
, B.febrero, B.marzo, B.abril, B.mayo, B.junio, B.julio, B.agosto, B.septiembre, B.octubre, B.noviembre, B.diciembre, B.totalDiasTrabajados
FROM EMPLEADO AS A
JOIN diasLaborados AS B ON B.fkIdEmpleado = A.pkIdEmpleado
WHERE contratado = 'Si';

CREATE TABLE cierreDeNominas
(
pkIdCierreDeNominas VARCHAR(11) NULL, 
año INT NULL,
mes VARCHAR(45) NULL,
totalAPagar FLOAT NULL
);

INSERT INTO puesto (pkIdPuesto, nombre, añosDeExperiencia, fkIdPuestoSuperior, estado) VALUES ('1', 'Conserje', 1, '0','0'); 
INSERT INTO puesto (pkIdPuesto, nombre, añosDeExperiencia, fkIdPuestoSuperior, estado) VALUES ('2', 'Contador', 1, '0','0'); 
INSERT INTO puesto (pkIdPuesto, nombre, añosDeExperiencia, fkIdPuestoSuperior, estado) VALUES ('3', 'Secretaria', 1, '0','0'); 
INSERT INTO puesto (pkIdPuesto, nombre, añosDeExperiencia, fkIdPuestoSuperior, estado) VALUES ('4', 'Gerente', 1, '0','0'); 
INSERT INTO puesto (pkIdPuesto, nombre, añosDeExperiencia, fkIdPuestoSuperior, estado) VALUES ('5', 'Auxiliar de Compras', 1, '1','0');

INSERT INTO empresa(idEmpresa, nit, nombre, direccion, telefono, estatus) VALUES ('1', '23423423', 'EMPRESA1', '3era Calle', 234232, 0);
INSERT INTO empresa(idEmpresa, nit, nombre, direccion, telefono, estatus) VALUES ('2', '23423423', 'EMPRESA2', '3era Calle', 234232, 0);
INSERT INTO empresa(idEmpresa, nit, nombre, direccion, telefono, estatus) VALUES ('3', '23423423', 'EMPRESA3', '3era Calle', 234232, 0);
INSERT INTO empresa(idEmpresa, nit, nombre, direccion, telefono, estatus) VALUES ('4', '23423423', 'EMPRESA4', '3era Calle', 234232, 0);

INSERT INTO empleado(pkIdEmpleado, nombre, apellido, fechaDeNacimiento, sueldo, correo, direccion, contratado, añosDeExperiencia, telefono
, fechaContratacion, finDeContrato, fkIdPuesto, fkIdEmpresa, estado) 
VALUES ('1', 'Pedro', 'González', now(), 5000, 'jegnzc@gmail.com', '3era Calle', 'Si', 1, 4234232, NOW(), NOW(), '1', '1', '1');
INSERT INTO empleado(pkIdEmpleado, nombre, apellido, fechaDeNacimiento, sueldo, correo, direccion, contratado, añosDeExperiencia, telefono
, fechaContratacion, finDeContrato, fkIdPuesto, fkIdEmpresa, estado) 
VALUES ('2', 'Ernesto', 'Cruz', now(), 6000, 'jegnzc@gmail.com', '3era Calle', 'Si', 1, 4234232, NOW(), NOW(), '1', '1', '1');
INSERT INTO empleado(pkIdEmpleado, nombre, apellido, fechaDeNacimiento, sueldo, correo, direccion, contratado, añosDeExperiencia, telefono
, fechaContratacion, finDeContrato, fkIdPuesto, fkIdEmpresa, estado) 
VALUES ('3', 'Roberto', 'González', now(), 7000, 'jegnzc@gmail.com', '3era Calle', 'Si', 1, 4234232, NOW(), NOW(), '1', '1', '1');
INSERT INTO empleado(pkIdEmpleado, nombre, apellido, fechaDeNacimiento, sueldo, correo, direccion, contratado, añosDeExperiencia, telefono
, fechaContratacion, finDeContrato, fkIdPuesto, fkIdEmpresa, estado) 
VALUES ('4', 'Luis', 'Carrera', now(), 8000, 'jegnzc@gmail.com', '3era Calle', 'Si', 1, 4234232, NOW(), NOW(), '1', '1', '1');
INSERT INTO empleado(pkIdEmpleado, nombre, apellido, fechaDeNacimiento, sueldo, correo, direccion, contratado, añosDeExperiencia, telefono
, fechaContratacion, finDeContrato, fkIdPuesto, fkIdEmpresa, estado) 
VALUES ('5', 'Jorge', 'Barrera', now(), 9000, 'jegnzc@gmail.com', '3era Calle', 'Si', 1, 4234232, NOW(), NOW(), '1', '1', '1');
INSERT INTO empleado(pkIdEmpleado, nombre, apellido, fechaDeNacimiento, sueldo, correo, direccion, contratado, añosDeExperiencia, telefono
, fechaContratacion, finDeContrato, fkIdPuesto, fkIdEmpresa, estado) 
VALUES ('6', 'Abidan', 'Cruz', now(), 15000, 'jegnzc@gmail.com', '3era Calle', 'Si', 1, 4234232, NOW(), NOW(), '1', '1', '1');
INSERT INTO empleado(pkIdEmpleado, nombre, apellido, fechaDeNacimiento, sueldo, correo, direccion, contratado, añosDeExperiencia, telefono
, fechaContratacion, finDeContrato, fkIdPuesto, fkIdEmpresa, estado) 
VALUES ('7', 'Ernesto', 'Fernandez', now(), 3000, 'jegnzc@gmail.com', '3era Calle', 'Si', 1, 4234232, NOW(), NOW(), '1', '1', '1');
INSERT INTO empleado(pkIdEmpleado, nombre, apellido, fechaDeNacimiento, sueldo, correo, direccion, contratado, añosDeExperiencia, telefono
, fechaContratacion, finDeContrato, fkIdPuesto, fkIdEmpresa, estado) 
VALUES ('8', 'José', 'López', now(), 3000, 'jegnzc@gmail.com', '3era Calle', 'Si', 1, 4234232, NOW(), NOW(), '1', '1', '1');
INSERT INTO empleado(pkIdEmpleado, nombre, apellido, fechaDeNacimiento, sueldo, correo, direccion, contratado, añosDeExperiencia, telefono
, fechaContratacion, finDeContrato, fkIdPuesto, fkIdEmpresa, estado) 
VALUES ('9', 'Melanie', 'González', now(), 4000, 'jegnzc@gmail.com', '3era Calle', 'Si', 1, 4234232, NOW(), NOW(), '1', '1', '1');
INSERT INTO empleado(pkIdEmpleado, nombre, apellido, fechaDeNacimiento, sueldo, correo, direccion, contratado, añosDeExperiencia, telefono
, fechaContratacion, finDeContrato, fkIdPuesto, fkIdEmpresa, estado) 
VALUES ('10', 'Estuardo', 'González', now(), 4000, 'jegnzc@gmail.com', '3era Calle', 'Si', 1, 4234232, NOW(), NOW(), '1', '1', '1');
INSERT INTO empleado(pkIdEmpleado, nombre, apellido, fechaDeNacimiento, sueldo, correo, direccion, contratado, añosDeExperiencia, telefono
, fechaContratacion, finDeContrato, fkIdPuesto, fkIdEmpresa, estado) 
VALUES ('11', 'Esduardo', 'Barrera', now(), 3000, 'jegnzc@gmail.com', '3era Calle', 'Si', 1, 4234232, NOW(), NOW(), '1', '1', '1');


INSERT INTO `hotelsancarlos`.`diaslaborados`
(`pkDiasTrabajados`, `fkIdEmpleado`, `año`,`enero`, `febrero`, `marzo`,`abril`,`mayo`,`junio`,`julio`,`agosto`
,`septiembre`,`octubre`,`noviembre`,`diciembre`,`totalDiasTrabajados`, estado)VALUES('1','1',2021,20,20,22,22,21,25,18,16,
17,20,15,21,240,"A");
INSERT INTO `hotelsancarlos`.`diaslaborados`
(`pkDiasTrabajados`, `fkIdEmpleado`, `año`,`enero`, `febrero`, `marzo`,`abril`,`mayo`,`junio`,`julio`,`agosto`
,`septiembre`,`octubre`,`noviembre`,`diciembre`,`totalDiasTrabajados`, estado)VALUES('2','2',2021,20,20,22,22,21,25,18,16,
17,20,15,21,200,"A");
INSERT INTO `hotelsancarlos`.`diaslaborados`
(`pkDiasTrabajados`, `fkIdEmpleado`, `año`,`enero`, `febrero`, `marzo`,`abril`,`mayo`,`junio`,`julio`,`agosto`
,`septiembre`,`octubre`,`noviembre`,`diciembre`,`totalDiasTrabajados`, estado)VALUES('3','3',2021,20,20,22,22,21,25,18,16,
17,20,15,21,230,"A");
INSERT INTO `hotelsancarlos`.`diaslaborados`
(`pkDiasTrabajados`, `fkIdEmpleado`, `año`,`enero`, `febrero`, `marzo`,`abril`,`mayo`,`junio`,`julio`,`agosto`
,`septiembre`,`octubre`,`noviembre`,`diciembre`,`totalDiasTrabajados`, estado)VALUES('4','4',2021,20,20,22,22,21,25,18,16,
17,20,15,21,250,"A");
INSERT INTO `hotelsancarlos`.`diaslaborados`
(`pkDiasTrabajados`, `fkIdEmpleado`, `año`,`enero`, `febrero`, `marzo`,`abril`,`mayo`,`junio`,`julio`,`agosto`
,`septiembre`,`octubre`,`noviembre`,`diciembre`,`totalDiasTrabajados`, estado)VALUES('5','5',2021,20,20,22,22,21,25,18,16,
17,20,15,10,230,"A");
INSERT INTO `hotelsancarlos`.`diaslaborados`
(`pkDiasTrabajados`, `fkIdEmpleado`, `año`,`enero`, `febrero`, `marzo`,`abril`,`mayo`,`junio`,`julio`,`agosto`
,`septiembre`,`octubre`,`noviembre`,`diciembre`,`totalDiasTrabajados`, estado)VALUES('6','6',2021,20,20,22,22,21,25,18,16,
17,20,15,1,230,"A");
INSERT INTO `hotelsancarlos`.`diaslaborados`
(`pkDiasTrabajados`, `fkIdEmpleado`, `año`,`enero`, `febrero`, `marzo`,`abril`,`mayo`,`junio`,`julio`,`agosto`
,`septiembre`,`octubre`,`noviembre`,`diciembre`,`totalDiasTrabajados`, estado)VALUES('7','7',2021,20,20,22,22,21,25,18,16,
17,20, 5,21,230,"A");
INSERT INTO `hotelsancarlos`.`diaslaborados`
(`pkDiasTrabajados`, `fkIdEmpleado`, `año`,`enero`, `febrero`, `marzo`,`abril`,`mayo`,`junio`,`julio`,`agosto`
,`septiembre`,`octubre`,`noviembre`,`diciembre`,`totalDiasTrabajados`, estado)VALUES('8','8',2021,20,20,22,22,21,25,18,16,
17,20,15,16,230,"A");
INSERT INTO `hotelsancarlos`.`diaslaborados`
(`pkDiasTrabajados`, `fkIdEmpleado`, `año`,`enero`, `febrero`, `marzo`,`abril`,`mayo`,`junio`,`julio`,`agosto`
,`septiembre`,`octubre`,`noviembre`,`diciembre`,`totalDiasTrabajados`, estado)VALUES('9','9',2021,20,20,22,22,21,25,18,16,
19,20,15,21,230,"A");
INSERT INTO `hotelsancarlos`.`diaslaborados`
(`pkDiasTrabajados`, `fkIdEmpleado`, `año`,`enero`, `febrero`, `marzo`,`abril`,`mayo`,`junio`,`julio`,`agosto`
,`septiembre`,`octubre`,`noviembre`,`diciembre`,`totalDiasTrabajados`, estado)VALUES('10','10',2021,20,20,22,22,21,25,18,16,
17,20,15,21,230,"A");

/*Liquidacion - Prestaciones*/
insert into prestacionlaboral values("1", "Aguinaldo","3","Monto total de Aguinaldo","A");
insert into prestacionlaboral values("2", "Indemnizacion","1","Monto total de Indemnizacion","A");
insert into prestacionlaboral values("3", "Vacaciones","2","Monto total de Vacaciones","A");
insert into prestacionlaboral values("4", "Bono 14","4","Monto total de vacaciones","A");
insert into prestacionlaboral values("5", "Salarios Pendientes","5","Monto total de salarios pendientes","A");

/*Enlaces contables*/
insert into tipoCuenta values ('1', 'Activo','A');
insert into tipoCuenta values ('2', 'Activo Corriente','A');
insert into tipoCuenta values ('3', 'Pasivo ','A');
insert into tipoCuenta values ('4', 'Pasivo Corriente','A');

insert into cuenta values ('1', 'impuesto','1','0','0','0','A','1');
insert into cuenta values ('2', 'impuesto2','1','0','0','0','A','1');
insert into cuenta values ('3', 'impuesto3','1','0','0','0','A','1');

insert into tipoPoliza values ('1','Poliza Ingresos', 'A');
insert into tipoPoliza values ('2','Poliza Egresos', 'A');
insert into tipoPoliza values ('3','Poliza Total', 'A');

insert into tipoOperacion values ('1', 'Debe', 'A');
insert into tipoOperacion values ('2', 'Haber', 'A');

insert into polizaEncabezado values ('1', '2021-10-1', '1');
insert into polizaEncabezado values ('2', '2021-10-2', '1');
insert into polizaEncabezado values ('3', '2021-10-3', '1');

insert into polizaDetalle values ('1', '2021-10-1', '1', '100', '1', 'Nomina');
insert into polizaDetalle values ('1', '2021-10-1', '2', '100', '2', 'Nomina');
insert into polizaDetalle values ('2', '2021-10-2','1', '100', '1', 'Nomina');
insert into polizaDetalle values ('2', '2021-10-2','2', '100', '2', 'Nomina');
insert into polizaDetalle values ('3', '2021-10-3', '1', '100', '1', 'Nomina');
insert into polizaDetalle values ('3', '2021-10-3','2', '100', '2', 'Nomina');

