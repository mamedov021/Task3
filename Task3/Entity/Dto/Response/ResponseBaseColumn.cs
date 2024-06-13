namespace Task3.Entity.Dto.Response
{


    public class ResponseBaseColumn
    {

        public string Status { get; set; } = string.Empty;

        public object? Data { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
