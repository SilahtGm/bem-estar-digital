using MauiAppBemEstarDigital.Models;
using SQLite;

namespace MauiAppBemEstarDigital.Helpers
{
    public class SQLiteDatabaseHelper
    {

        readonly SQLiteAsyncConnection _conn;

        public SQLiteDatabaseHelper(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<Usuario>().Wait();
        }


        public async Task<Usuario> LoginAsync(string email, string senha)
        {
            // Busca um usuário com email e senha correspondentes
            var usuario = await _conn.Table<Usuario>()
                                     .Where(u => u.Email == email && u.Senha == senha)
                                     .FirstOrDefaultAsync();

            return usuario; // Retorna null se não encontrar
        }

        public async Task<bool> CriarContaAsync(Usuario u)
        {
            // Verifica se já existe usuário com o mesmo email
            var existente = await _conn.Table<Usuario>()
                                        .Where(x => x.Email == u.Email)
                                        .FirstOrDefaultAsync();

            if (existente != null)
            {
                // Se o usuário já existe
                return false;
            }

            // Se este usuário ainda nao existe, insere o novo usuário
            await _conn.InsertAsync(u);
            return true;
        }


    }
}
