namespace Aria2.Contracts.Models
{
    public enum EventPollMethod
    {
        Epoll,
        kqueue,
        port,
        Poll,
        Select
    }
}
