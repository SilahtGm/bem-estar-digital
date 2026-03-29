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
            _conn.CreateTableAsync<PesoUsuario>().Wait();
            _conn.CreateTableAsync<Lembrete>().Wait();
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



        // Recupera todos os registros do usuário
        public async Task<List<PesoUsuario>> GetHistoricoIMCAsync(int usuarioId)
        {
            var historico = await _conn.Table<PesoUsuario>()
                                       .Where(x => x.U_Id == usuarioId)
                                       .OrderByDescending(x => x.Data) // do mais recente para o mais antigo
                                       .ToListAsync();
            return historico;
        }

        // Insere um novo registro de peso/altura/IMC
        public async Task InserirPesoAsync(PesoUsuario registro)
        {
            await _conn.InsertAsync(registro);
        }

        public Task<int> InserirLembreteAsync(Lembrete lembrete)
        {
            return _conn.InsertAsync(lembrete);
        }


        public Task<List<Lembrete>> ListarLembretesPorUsuarioAsync(int usuarioId)
        {
            return _conn.Table<Lembrete>()
                            .Where(l => l.U_Id == usuarioId)
                            .ToListAsync();
        }

        public Task<int> AtualizarLembreteAsync(Lembrete lembrete)
        {
            return _conn.UpdateAsync(lembrete);
        }


        public Task<int> DeletarLembretePorIdAsync(int id)
        {
            return _conn.DeleteAsync<Lembrete>(id);
        }

    }

}
