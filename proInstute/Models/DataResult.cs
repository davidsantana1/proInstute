namespace proInstute.Domain.Models
{
    public class DataResult<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
