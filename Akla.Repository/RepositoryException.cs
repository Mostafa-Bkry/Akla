namespace Akla.Repository
{
    /// <summary>
    /// Custom repository exception to wrap low-level data access errors.
    /// </summary>
    public class RepositoryException : Exception
    {
        public RepositoryException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
