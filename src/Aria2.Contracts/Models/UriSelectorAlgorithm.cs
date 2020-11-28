namespace Aria2.Contracts.Models
{
    /// <summary>
    /// Specifies algorithm of URI selection.
    /// </summary>
    public enum UriSelectorAlgorithm
    {
        /// <summary>
        /// Selects one of the
        /// best mirrors for
        /// the first and
        /// reserved connections.
        /// </summary>
        Adaptive,
        /// <summary>
        /// Uses download speed
        /// observed in the
        /// previous downloads
        /// and chooses fastest
        /// server in the URI list.
        /// </summary>
        Feedback,
        /// <summary>
        /// URI is tried in the
        /// order appeared in
        /// the URI list.
        /// </summary>
        Inorder
    }
}
