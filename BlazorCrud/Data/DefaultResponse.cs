namespace BlazorCrud.Data {
    public class DefaultResponse<T> {

        public int Success { get; set; }
        public int Failure { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

    }
}
