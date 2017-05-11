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
            => httpclient.BaseAddress = new Uri("https://api.hotslogs.com");

        /// <summary>
        /// Returns a list of all heroes.
        /// </summary>
        /// <returns>Returns a list of all heroes.</returns>
        public async Task<IEnumerable<Hero>> GetHeroes()
        {
            return await await Task.Factory.StartNew(async () =>
                JsonConvert.DeserializeObject<IEnumerable<Hero>>(
                    await GetStringAsync(Endpoints.Heroes)));
        }

        /// <summary>
        /// Returns a list of all maps.
        /// </summary>
        /// <returns>Returns a list of all maps.</returns>
        public async Task<IEnumerable<Map>> GetMaps()
        {
            return await await Task.Factory.StartNew(async () =>
                JsonConvert.DeserializeObject<IEnumerable<Map>>(
                    await GetStringAsync(Endpoints.Maps)));
        }

        /// <summary>
        /// Returns a list of all events.
        /// </summary>
        /// <returns>Returns a list of all events.</returns>
        public async Task<IEnumerable<Event>> GetEvents()
        {
            return await await Task.Factory.StartNew(async () =>
                JsonConvert.DeserializeObject<IEnumerable<Event>>(
                    await GetStringAsync(Endpoints.Events)));
        }

        /// <summary>
        /// Returns data about a player.
        /// </summary>
        /// <returns>Returns data about a player.</returns>
        public async Task<Player> GetPlayerSummary(Region region, string battletag)
        {
            return await await Task.Factory.StartNew(async () =>
                JsonConvert.DeserializeObject<Player>(
                    await GetStringAsync(Endpoints.Players, ((int)region).ToString(), battletag)));
        }

        /// <summary>
        /// Returns data about a player.
        /// </summary>
        /// <returns>Returns data about a player.</returns>
        public async Task<Player> GetPlayerSummary(int playerID)
        {
            return await await Task.Factory.StartNew(async () =>
                JsonConvert.DeserializeObject<Player>(
                    await GetStringAsync(Endpoints.Players, playerID.ToString())));
        }

        /// <summary>
        /// Releases the unmanaged resources and disposes of the managed resources used.
        /// </summary>
        public void Dispose()
        {
            httpclient.Dispose();
        }

        private async Task<string> GetStringAsync(string endpoint, params string[] parameters)
        {
            return await httpclient.GetStringAsync(
                endpoint + "/" + string.Join("/", parameters));
        }
    }
}
