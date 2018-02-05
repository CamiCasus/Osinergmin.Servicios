using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Domain.MainModule.Osinergmin
{
    public static class Codigos
    {
        public static Dictionary<string, string> MENSAJES_ERROR = new Dictionary<string, string>()
        {
            {"01", "Se generó un error genérico en el flujo del proceso" },
            {"02", "Se generó un error al momento de procesar la información" },
            {"03", "Se está tratando de registrar un informe con un Usuario no autorizado" },
            {"04", "Existe información obligatoria que no se está enviando" },
            {"05", "Las credenciales de acceso ingresadas no son válidas" },
            {"06", "Existe un informe que todavía no ha sido verificado por el especialista, no puede versionar el informe" },
            {"07", "Ya se cuenta con el informe correspondiente al establecimiento ingresado, el cual se encuentra Aceptado, no se puede versionar" },
            {"08", "El informe no tiene detalles" },
            {"09", "El producto se está repitiendo en mas de un detalle" },
            {"10", "El código del producto ingresado no existe" },
            {"11", "El número de guía no existe" },
            {"12", "Muestra repetida" },
            {"13", "No se puede agregar mas muestras a la guía" },
            {"14", "No se especifica si se está versionando o no la guía" },
            {"15", "la guia ya fue presentada" },
            {"16", "La guía todavía no ha sido presentada, no puede versionar" },
            {"17", "No existe muestras para versionar.No existe muestra" },
            {"18", "El código del establecimiento no es válido" },
            {"19", "El código del ERH asociado al código de establecimiento no es válido" },
            {"20", "Existe una Guia registrada con el mismo código" },
        };      
    }
}
