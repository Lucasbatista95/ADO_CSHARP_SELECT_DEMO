using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

public class Database
{
    // A chave scnn deve ser configurada no config da aplicalçao, na sessão ConnectionStrings
    string scnn = ConfigurationManager.ConnectionStrings["scnn"].ToString();

    public List<Client> ObterClientes()
    {
        var clientes = new List<Client>();

        var cn = new SqlConnection(scnn);

        cn.Open();

        var cmd = new SqlCommand("SELECT * FROM Clients", cn);

        var dados = cmd.ExecuteReader();

        while (dados.Read())
        {
            var c = new Client();

            c.Name = dados["Name"].ToString();
            c.Email = dados["Email"].ToString();
            c.Phone = dados["Phone"].ToString();

            clientes.Add(c);
        }

        cn.Close();

        return clientes;
    }
}
