namespace Aria2.Contracts.Models
{
    /// <summary>
    /// Specifies method for events polling.
    /// </summary>
    public enum EventPollMethod
    {
        /// <summary>
        /// epoll.
        /// </summary>
        Epoll,
        /// <summary>
        /// kqueue.
        /// </summary>
        /// <remarks>
        /// Available on various
        /// *BSD systems including Mac OS X.
        /// </remarks>
        Kqueue,
        /// <summary>
        /// port.
        /// </summary>
        /// <remarks>
        /// Available on Open Solaris.
        /// </remarks>
        Port,
        /// <summary>
        /// poll.
        /// </summary>
        Poll,
        /// <summary>
        /// select.
        /// </summary>
        Select
    }
}