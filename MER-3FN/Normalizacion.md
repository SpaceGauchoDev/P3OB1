---
title: Normalizacion
created: '2020-10-12T02:25:10.800Z'
modified: '2020-10-12T17:10:06.935Z'
---

# Normalizacion

**Usuario** (<ins>**CI**</ins>, Pass, Rol, Nombre, Apellido, FechaDeNacimiento, Celular)

**Proyecto** (<ins>**IdProyecto**</ins>, Etapa, TipoDeEquipo, Titulo, Descripcion, ImgURL, CantidadIntegrantes, ExperienciaIndividual, FechaDePresentacion *CI*)

**Financiacion** (<ins>**IdFinanciacion**</ins>, Cuotas, PrecioPorCuota, MontoSolicitado, PorcentajeDeInteres, *IdProyecto*)

**Evaluacion** (<ins>**IdEvaluacion**</ins>, FueEvaluado, PuntajeDeEvaluacion, FechaDeEvaluacion, *IdProyecto*, *CI*)

**Configuraciones** (<ins>**IdConfig**</ins>, MinEdad, MinMonto, MaxMonto, MinCuotas, MaxCuotas, PenalizacionPorIndividual, BonoPorIntegrante, MaxBonoTotal, FechaDeActualización)

**InteresPorCuotas** (<ins>**Cuotas**</ins>, PorcentajeDeInteres, *IdConfig*)



