namespace BlazorCrud.Data {
    public class DefaultResponse {

        public int Success { get; set; }
        public int Failure { get; set; }
        public string Message { get; set; }
        public List<Beer> Data { get; set; }

    }
}
