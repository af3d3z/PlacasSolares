using PlacasSolares.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacasSolares.DAL
{
    /*
        Tengo esto por carpetas en vez de por proyectos por falta de tiempo porque el día anterior a la entrega estuve enfermo.
     */
    public class ListadoCitas
    {
        /// <summary>
        /// Función estática que devuelve una lista de citas
        /// </summary>
        /// <returns></returns>
        public static List<Cita> GetCitas()
        {
            List<Cita> citas = new List<Cita>();
            citas.Add(new Cita(1, "Tanque roto", "C\\ Maria Teresa 32", new DateTime(2024, 11, 19, 8, 1, 0), "Carlos Pérez"));
            citas.Add(new Cita(2, "Revisión de paneles solares", "C\\ María Teresa 34", new DateTime(2024, 11, 19, 9, 0, 0), "Lucía Martínez"));
            citas.Add(new Cita(3, "Instalación de nuevo inversor", "C\\ María Teresa 36", new DateTime(2024, 11, 19, 10, 30, 0), "Javier López"));
            citas.Add(new Cita(4, "Mantenimiento de sistema solar", "C\\ María Teresa 38", new DateTime(2024, 11, 19, 12, 0, 0), "Ana Torres"));
            citas.Add(new Cita(5, "Limpieza de paneles solares", "C\\ María Teresa 40", new DateTime(2024, 11, 19, 14, 15, 0), "Diego Romero"));
            citas.Add(new Cita(6, "Reparación de conexiones eléctricas", "C\\ María Teresa 42", new DateTime(2024, 11, 20, 9, 0, 0), "Marta González"));
            citas.Add(new Cita(7, "Sustitución de panel defectuoso", "C\\ María Teresa 44", new DateTime(2024, 11, 20, 11, 30, 0), "Andrés Sánchez"));
            citas.Add(new Cita(8, "Chequeo de sistema de monitoreo", "C\\ María Teresa 46", new DateTime(2024, 11, 20, 13, 0, 0), "Claudia Jiménez"));
            citas.Add(new Cita(9, "Revisión de baterías", "C\\ María Teresa 48", new DateTime(2024, 11, 21, 9, 0, 0), "Fernando Díaz"));
            citas.Add(new Cita(10, "Ajuste de ángulo de paneles", "C\\ María Teresa 50", new DateTime(2024, 11, 21, 11, 30, 0), "Elena Ramírez"));
            citas.Add(new Cita(11, "Diagnóstico de fallos", "C\\ María Teresa 52", new DateTime(2024, 11, 21, 14, 0, 0), "Roberto Silva"));
            citas.Add(new Cita(12, "Revisión de cableado", "C\\ María Teresa 54", new DateTime(2024, 11, 22, 9, 0, 0), "Verónica Castro"));
            citas.Add(new Cita(13, "Optimización del sistema", "C\\ María Teresa 56", new DateTime(2024, 11, 22, 10, 30, 0), "Sergio Morales"));
            citas.Add(new Cita(14, "Verificación de consumo energético", "C\\ María Teresa 58", new DateTime(2024, 11, 22, 12, 0, 0), "Patricia Ruiz"));
            citas.Add(new Cita(15, "Instalación de protección contra sobretensiones", "C\\ María Teresa 60", new DateTime(2024, 11, 23, 9, 0, 0), "Luis Fernández"));
            citas.Add(new Cita(16, "Revisión post-instalación", "C\\ María Teresa 62", new DateTime(2024, 11, 23, 11, 30, 0), "Natalia Herrera"));
            citas.Add(new Cita(17, "Limpieza de sistema de drenaje", "C\\ María Teresa 64", new DateTime(2024, 11, 23, 14, 0, 0), "Felipe Castillo"));
            citas.Add(new Cita(18, "Evaluación de rendimiento", "C\\ María Teresa 66", new DateTime(2024, 11, 24, 9, 0, 0), "Carmen Ortega"));
            citas.Add(new Cita(19, "Reparación de soporte de panel", "C\\ María Teresa 68", new DateTime(2024, 11, 24, 11, 30, 0), "Esteban Delgado"));
            citas.Add(new Cita(20, "Instalación de sensores de temperatura", "C\\ María Teresa 70", new DateTime(2024, 11, 24, 14, 0, 0), "Gabriela Núñez"));

            return citas;
        }

    }
}
