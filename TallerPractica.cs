using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion

{
       private static LiquidacionCuotaModerada CapturarDatos()
    {
        Paciente = paciente;
        string identificacion, numeroliquidacion, tipoafiliacion;
        int salariodevengado, valorservicio;
        Console.WriteLine("Identificacion");
        identificacion = Console.ReadLine();
        Console.WriteLine("Numero de la liquidacion");
        numeroliquidacion = Console.ReadLine();
        Console.WriteLine("Tipo de Afiliacion");
        tipoafiliacion = Console.ReadLine();
        Console.WriteLine("Salario Devengado");
        salariodevengado = int.Parse(Console.ReadLine());
        Console.WriteLine("Valor del Servicio");
        valorservicio = int.Parse(Console.ReadLine());
        paciente = new(identificacion, numeroliquidacion, tipoafiliacion, salariodevengado, valorservicio); 
        
    }








    }
}
