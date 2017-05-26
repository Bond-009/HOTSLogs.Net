using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HOTSLogs
{
    public class HOTSLogsClient : IDisposable
    {
        HttpClient httpclient = new HttpClient();

        public HOTSLogsClient()
            => httpclient.BaseAddress = new Uri(Endpoints.BaseUrl);

        /// <summary>
        /// Returns a list of all heroes.
        /// </summary>
        /// <returns>Returns a list of all heroes.</returns>
        public Task<IEnumerable<Hero>> GetHeroes()
            => GetObjectAsync<IEnumerable<Hero>>(Endpoints.Heroes);

        /// <summary>
        /// Returns a list of all maps.
        /// </summary>
        /// <returns>Returns a list of all maps.</returns>
        public Task<IEnumerable<Map>> GetMaps()
            => GetObjectAsync<IEnumerable<Map>>(Endpoints.Maps);

        /// <summary>
        /// Returns a list of all events.
        /// </summary>
        /// <returns>Returns a list of all events.</returns>
        public Task<IEnumerable<Event>> GetEvents()
            => GetObjectAsync<IEnumerable<Event>>(Endpoints.Events);

        /// <summary>
        /// Returns data about a player.
        /// </summary>
        /// <returns>Returns data about a player.</returns>
        public Task<Player> GetPlayerSummary(Region region, string battletag)
            => GetObjectAsync<Player>(Endpoints.Players, ((int)region).ToString(), battletag);

        /// <summary>
        /// Returns data about a player.
        /// </summary>
        /// <returns>Returns data about a player.</returns>
        public Task<Player> GetPlayerSummary(int playerID)
            => GetObjectAsync<Player>(Endpoints.Players, playerID.ToString());

        /// <summary>
        /// Releases the unmanaged resources and disposes of the managed resources used.
        /// </summary>
        public void Dispose() => httpclient.Dispose();

        private async Task<T> GetObjectAsync<T>(string endpoint, params string[] parameters)
            => JsonConvert.DeserializeObject<T>(
                    await httpclient.GetStringAsync(endpoint + "/" + string.Join("/", parameters)
                ));
    }
}
