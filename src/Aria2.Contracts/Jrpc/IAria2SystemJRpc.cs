using System.Threading.Tasks;

namespace Aria2.Contracts.Jrpc
{
    /// <summary>
    /// Aria2 system JSON-RPC contract interface.
    /// </summary>
    public interface IAria2SystemJRpc
    {
        /// <summary>
        /// Returns all the available RPC methods.
        /// </summary>
        /// <returns>
        /// Array of the available RPC method names.
        /// </returns>
        Task<string[]> ListMethods();

        /// <summary>
        /// Returns all the available RPC notifications.
        /// </summary>
        /// <returns>
        /// Array of the available RPC notification names.
        /// </returns>
        Task<string[]> ListNotifications();
    }
}