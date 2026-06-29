using Microsoft.Data.SqlClient;
using TesteDevCSharp.Data;
using TesteDevCSharp.Models;

namespace TesteDevCSharp.Services
{
    public class UsuarioService
    {
        private readonly ConnectionFactory _connectionFactory;

        public UsuarioService(ConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public void CriarUsuario(Usuario usuario)
        {
            using var connection = _connectionFactory.CreateConnection();

            var sql = @"INSERT INTO Usuarios
                (Nome, NomeUsuario, Senha)
                VALUES
                (@Nome, @NomeUsuario, @Senha)";

            var command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@Nome", usuario.Nome);
            command.Parameters.AddWithValue("@NomeUsuario", usuario.NomeUsuario);
            command.Parameters.AddWithValue("@Senha", usuario.Senha);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}