namespace Aria2.Contracts
{
    public static class RpcMethodsNameFactory
    {
        /// <summary>
        /// Method name transformation for aria2 JSON-RPC requests.
        /// </summary>
        /// <param name="name">Method name.</param>
        /// <returns>
        /// Transformed method name.
        /// </returns>
        public static string TransformAria2RpcName(string name) => $"aria2.{StringToCamelCase(name)}";

        /// <summary>
        /// Method name transformation for aria2 system JSON-RPC requests.
        /// </summary>
        /// <param name="name">Method name.</param>
        /// <returns>
        /// Transformed method name.
        /// </returns>
        public static string TransformAria2SystemRpcName(string name) => $"system.{StringToCamelCase(name)}";

        private static string StringToCamelCase(string s) => char.ToLower(s[0]) + s[1..];
    }
}