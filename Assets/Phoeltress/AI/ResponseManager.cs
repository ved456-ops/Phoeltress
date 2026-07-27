public static class ResponseManager
{
    public static AIResponse LatestResponse { get; private set; }

    public static void SetResponse(AIResponse response)
    {
        LatestResponse = response;
    }

    public static AIResponse GetResponse()
    {
        return LatestResponse;
    }
}