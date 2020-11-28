namespace Aria2.Contracts.Models
{
    /// <summary>
    /// Specifies algorithm for block selection.
    /// </summary>
    public enum BlockSelectorAlgorithm
    {
        /// <summary>
        /// Block selection algorithm
        /// based on reducing the
        /// number of establishing connections.
        /// </summary>
        Default,
        /// <summary>
        /// Block selection algorithm
        /// based on minimum index.
        /// </summary>
        Inorder,
        /// <summary>
        /// Block selection algorithm
        /// based on random selection.
        /// </summary>
        Random,
        /// <summary>
        /// Block selection algorithm
        /// like <see cref="Inorder"/>
        /// with exponentially increasing
        /// space saving from previously
        /// selected block.
        /// </summary>
        Geom
    }
}
