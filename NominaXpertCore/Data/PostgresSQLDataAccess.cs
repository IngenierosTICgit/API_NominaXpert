using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlEscolar.Utilities;
using NLog; //Paqueteria en la que se llaman los log 
using Npgsql;

namespace ControlEscolar.Data
{
    /// <summary>
    /// Clase que maneja el acceso a datos PostgreSQL, incluyendo conexiones, colsultas,
    /// y ejecución de procedimientos almacenados
    /// </summary>
    public class PostgresSQLDataAccess
    {
        //Logger usando el LoggingManager centralizado
        private static readonly Logger _logger;

        // Campo estático para almacenar la cadena de conexión
        private static string _connectionString;

        private NpgsqlConnection _connection;
        private static PostgresSQLDataAccess? _instance;

        // Constructor estático para inicializar el logger
        static PostgresSQLDataAccess()
        {
            try
            {
                _logger = LoggingManager.GetLogger("ControlEscolar.Data.PostgresSQLDataAccess");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inicializando logger: {ex.Message}");
                throw;
            }
        }

        // Propiedad para establecer la cadena de conexión desde el API
        public static string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(_connectionString))
                {
                    try
                    {
                        // Intenta obtener desde ConfigurationManager (Windows Forms)
                        _connectionString = ConfigurationManager.ConnectionStrings["ConexionBD"]?.ConnectionString;
                    }
                    catch (Exception ex)
                    {
                        _logger.Warn(ex, "No se pudo obtener la cadena de conexión desde ConfigurationManager");
                    }
                }
                return _connectionString;
            }
            set
            {
                _connectionString = value;
                Console.WriteLine($"PostgreSQLDataAccess: Cadena de conexión establecida: {(!string.IsNullOrEmpty(value) ? "CONFIGURADA" : "NULL")}");
            }
        }

        /// <summary>
        /// Constructor privado para implementar el patrón Singleton
        /// </summary>
        private PostgresSQLDataAccess()
        {
            try
            {
                if (string.IsNullOrEmpty(ConnectionString))
                {
                    throw new InvalidOperationException("La cadena de conexión no está configurada. Asegúrate de establecer PostgreSQLDataAccess.ConnectionString antes de usar la clase.");
                }

                _connection = new NpgsqlConnection(ConnectionString);
                _logger.Info("Instancia de acceso a datos creada correctamente");
            }
            catch (Exception ex)
            {
                _logger.Fatal(ex, "Error al inicializar el acceso a la base de datos");
                throw;
            }
        }

        public static PostgresSQLDataAccess GetInstance()
        {
            if (_instance == null)
            {
                _instance = new PostgresSQLDataAccess();
            }
            return _instance;
        }

        /// <summary>
        /// Establece la conexion con la base de datos
        /// </summary>
        public bool Connect()
        {
            try
            {
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                    _logger.Info("Conexión a la base de datos establecida correctamente");
                }
                return true;
            }
            catch (Exception ex)
            {
                _logger.Fatal(ex, "Error al abrir la conexión a la base de datos");
                throw;
            }
        }

        public bool Disconnect()
        {
            try
            {
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                    _logger.Info("Conexión de la base de datos cerrada correctamente");
                }
                return true;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al cerrar la conexión");
                throw;
            }
        }

        public DataTable ExecuteQuery_Reader(string query, params NpgsqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();

            try
            {
                _logger.Info($"Ejecutando consulta en la base de datos: {query}");
                using (NpgsqlCommand command = CreateCommand(query, parameters))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                        _logger.Debug($"Consulta ejecutada correctamente, {dataTable.Rows.Count} filas obtenidas");
                    }
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al ejecutar la consulta en la base de datos");
                throw;
            }
        }

        private NpgsqlCommand CreateCommand(string query, params NpgsqlParameter[] parameters)
        {
            NpgsqlCommand command = new NpgsqlCommand(query, _connection);
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
                foreach (NpgsqlParameter param in parameters)
                {
                    _logger.Debug($"Parámetro: {param.ParameterName} = {param.Value ?? "NULL"}");
                }
            }
            return command;
        }

        public int ExecuteNonQuery(string query, params NpgsqlParameter[] parameters)
        {
            try
            {
                _logger.Debug($"Ejecutando operacion: {query}");
                using (NpgsqlCommand command = CreateCommand(query, parameters))
                {
                    int result = command.ExecuteNonQuery();
                    _logger.Debug($"Consulta ejecutada correctamente, {result} filas afectadas");
                    return result;
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al ejecutar la consulta en la base de datos");
                throw;
            }
        }

        public object? ExecuteScalar(string query, params NpgsqlParameter[] parameters)
        {
            try
            {
                _logger.Debug($"Ejecutando consulta escalar: {query}");
                using (NpgsqlCommand command = CreateCommand(query, parameters))
                {
                    object? result = command.ExecuteScalar();
                    _logger.Debug($"Consulta ejecutada correctamente, ID afectado: {result}");
                    return result;
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al ejecutar la consulta en la base de datos");
                throw;
            }
        }

        public NpgsqlParameter CreateParameter(string name, object value)
        {
            return new NpgsqlParameter(name, value ?? DBNull.Value);
        }
    }
}