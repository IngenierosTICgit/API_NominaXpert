using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NominaXpertCore.Utilities
{
    internal class Validaciones
    {
        /// <summary>
        /// Valida si un correo electrónico es válido.
        /// Ejemplos válidos: usuario@example.com, nombre.apellido@dominio.mx, empleado123@empresa.org
        /// Ejemplos no válidos: usuario@@example.com (doble @), usuario.com (falta @), usuario@.com (falta dominio antes del punto)
        /// </summary>
        /// <param name="correo">Correo electrónico a validar</param>
        /// <returns>Retorna verdadero si el correo es válido, falso en caso contrario</returns>
        public static bool EsCorreoValido(string correo)
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(correo, patron);
        }

        /// <summary>
        /// Valida si una CURP es válida.
        /// Ejemplos válidos: GOML990101HDFRLR02, ROGA850505MDFLRS08
        /// Ejemplos no válidos: goml990101hdfrrl02 (minúsculas no permitidas), GOML990101XDFRLR02 (X no es válido para el sexo), GOML990101HDFRL (falta longitud correcta)
        /// </summary>
        /// <param name="curp">CURP a validar</param>
        /// <returns>Retorna verdadero si la CURP es válida, falso en caso contrario</returns>
        public static bool EsCURPValido(string curp)
        {
            string patron = @"^[A-Z]{4}\d{6}[HM][A-Z]{5}[A-Z0-9]{2}$";
            return Regex.IsMatch(curp, patron);
        }

        /// <summary>
        /// Valida si un número de teléfono es válido (10 dígitos).
        /// Ejemplos válidos: 5512345678, 7229876543
        /// Ejemplos no válidos: 123456789 (solo 9 dígitos), 55-1234-5678 (contiene guiones), telefono (contiene letras)
        /// </summary>
        /// <param name="telefono">Número de teléfono a validar</param>
        /// <returns>Retorna verdadero si el teléfono es válido, falso en caso contrario</returns>
        public static bool EsTelefonoValido(string telefono)
        {
            string patron = @"^\d{10}$";
            return Regex.IsMatch(telefono, patron);
        }

        /// <summary>
        /// Valida si un código postal es válido (5 dígitos).
        /// Ejemplos válidos: 50120, 01000
        /// Ejemplos no válidos: 5012 (menos de 5 dígitos), 501201 (más de 5 dígitos), ABCDE (contiene letras)
        /// </summary>
        /// <param name="cp">Código postal a validar</param>
        /// <returns>Retorna verdadero si el código postal es válido, falso en caso contrario</returns>
        public static bool EsCodigoPostalValido(string cp)
        {
            string patron = @"^\d{5}$";
            return Regex.IsMatch(cp, patron);
        }

        /// <summary>
        /// Valida si un RFC es válido.
        /// Ejemplos válidos: ABCD990101XYZ, ROGA8505051A2
        /// Ejemplos no válidos: abcd990101XYZ (minúsculas no permitidas), ABC990101XYZ (faltan caracteres en la parte inicial), ABCD990101XYZ1 (más caracteres de los permitidos)
        /// </summary>
        /// <param name="rfc">RFC a validar</param>
        /// <returns>Retorna verdadero si el RFC es válido, falso en caso contrario</returns>
        public static bool EsRFCValido(string rfc)
        {
            string patron = @"^[A-Z]{4}\d{6}[A-Z0-9]{3}$";
            return Regex.IsMatch(rfc, patron);
        }

        /// <summary>
        /// Valida si un nombre es válido (Debe empezar con mayúscula y no contener números).
        /// Ejemplos válidos: Juan, Maria Fernanda, Luis Alberto
        /// Ejemplos no válidos: juan (debe iniciar con mayúscula), JUAN (todo en mayúsculas no permitido), Juan3 (contiene números)
        /// </summary>
        /// <param name="nombre">Nombre a validar</param>
        /// <returns>Retorna verdadero si el nombre es válido, falso en caso contrario</returns>
        public static bool EsNombreValido(string nombre)
        {
            string patron = @"^[A-Z][a-z]+(\s[A-Z][a-z]+)*$";
            return Regex.IsMatch(nombre, patron);
        }

        /// <summary>
        /// Valida si un apellido es válido (Debe empezar con mayúscula y no contener números).
        /// Ejemplos válidos: Gomez, De La Cruz, Fernandez Lopez
        /// Ejemplos no válidos: gomez (debe iniciar con mayúscula), GOMEZ (todo en mayúsculas no permitido), Gomez123 (contiene números)
        /// </summary>
        /// <param name="apellido">Apellido a validar</param>
        /// <returns>Retorna verdadero si el apellido es válido, falso en caso contrario</returns>
        public static bool EsApellidoValido(string apellido)
        {
            string patron = @"^[A-Z][a-z]+(\s[A-Z][a-z]+)*$";
            return Regex.IsMatch(apellido, patron);
        }

        /// <summary>
        /// Valida si una dirección es válida (Debe empezar con mayúscula y no contener números).
        /// Ejemplos válidos: Avenida Reforma, Calle Juarez
        /// Ejemplos no válidos: calle 5 (no empieza con mayúscula), Calle-5 (contiene guiones no permitidos), Calle123 (contiene números)
        /// </summary>
        /// <param name="direccion">Dirección a validar</param>
        /// <returns>Retorna verdadero si la dirección es válida, falso en caso contrario</returns>
        public static bool EsDireccionValida(string direccion)
        {
            string patron = @"^[A-Z][a-z]+(\s[A-Z][a-z]+)*$";
            return Regex.IsMatch(direccion, patron);
        }

        /// <summary>
        /// Valida si un número es válido (Solo dígitos).
        /// Ejemplos válidos: 123, 987654
        /// Ejemplos no válidos: 123a (contiene letras), 1.23 (contiene punto decimal)
        /// </summary>
        /// <param name="numero">Número a validar</param>
        /// <returns>Retorna verdadero si el número es válido, falso en caso contrario</returns>
        public static bool EsNumeroValido(string numero)
        {
            string patron = @"^\d+$";
            return Regex.IsMatch(numero, patron);
        }

        /// <summary>
        /// Valida si un salario es válido (Solo números con hasta dos decimales).
        /// Ejemplos válidos: 1500, 12345.67, 9999.9
        /// Ejemplos no válidos: 1234.999 (más de dos decimales), salario (contiene letras), 12,345.67 (usa coma en lugar de punto)
        /// </summary>
        /// <param name="salario">Salario a validar</param>
        /// <returns>Retorna verdadero si el salario es válido, falso en caso contrario</returns>
        public static bool EsSalarioValido(string salario)
        {
            string patron = @"^\d+(\.\d{1,2})?$";
            return Regex.IsMatch(salario, patron);
        }
        /// <summary>
        /// Valida si una matrícula es válida según el formato específico.
        /// La matrícula debe comenzar con "E-", seguido de 4 dígitos, un guion "-", 
        /// y de 3 a 5 dígitos numéricos.
        /// E-2019-54321
        /// </summary>
        /// <param name="matricula">Matrícula a validar.</param>
        /// <returns>Retorna verdadero si la matrícula cumple con el formato especificado, falso en caso contrario.</returns>
        internal static bool EsNoMatriculaValido(string matricula)
        {
            if (string.IsNullOrEmpty(matricula)) return false;

            string patron = @"^E-\d{4}-\d{3,5}$";
            return Regex.IsMatch(matricula.Trim(), patron);
        }


    }
}
