﻿using Clase_22.Entidades;

public delegate void LimiteSueldoDelegado(double sueldo, Empleado emp);
public delegate void LimiteSueldoMejorado(Empleado sender, EmpleadoEventArgs e);

public enum TipoManejador
{
    LimiteSueldo,
    LimiteSueldoMejorado,
    Todos
}