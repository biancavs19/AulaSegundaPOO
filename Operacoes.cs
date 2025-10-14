using MySql.Data.MySqlClient;

public class Operacoes
{
    private string connectionString =
    @"server=phpmyadmin.uni9marize.us;User ID=user_poo;password=S3nh4!F0rt3;database_userpoo;";
    public int Criar(Tarefa tarefa)
    {
        using(var conexao = new MySqlConnection(connectionString))
        {
            conexao.Open();
            string sql = @"INSERT INTO tarefa(nome, descricao, dataCriacao, status, dataExecucao)
                            VALUES (@nome, @descricao, @dataCriacao, @satus, @dataExecucao);
                            SELECT LAST_INSERT_ID();";
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@nome", tarefa.Nome);
                cmd.Parameters.AddWithValue("@descricao", tarefa.Descricao);
                cmd.Parameters.AddWithValue("@dataCriacao", tarefa.DataCriacao);
                cmd.Parameters.AddWithValue("@status", tarefa.Status);
                cmd.Parameters.AddWithValue("@dataExecucao", tarefa.DataExecucao);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}