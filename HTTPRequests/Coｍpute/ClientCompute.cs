using RestSharp;
using System.Diagnostics;

namespace ConohaVPS.HTTPRequests.Coｍpute;

/// <summary>
/// Computeサーバーとのやり取りを担うクラス。
/// </summary>
public class ClientCompute
{
    private const string _http_header_Accept = "Accept";
    private const string _http_header_xAuthToken = "X-Auth-Token";
    private const string _contents_type = "application/json";

    private readonly RestClient _client;

    /// <summary>
    /// ClientConputeクラスのコンストラクタ。
    /// </summary>
    /// <param name="client">呼出先が持っているRestClientのインスタンス</param>
    public ClientCompute(RestClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Computeサーバーの基本的なバージョン情報を取得するメソッド。
    /// </summary>
    /// <returns>Computeサーバーからのレスポンス</returns>
    public async Task<RestResponse> RequestInfoAsync()
    {
        var url = "/";

        var request = new RestRequest(url, Method.Get);

        request.AddHeader(_http_header_Accept, _contents_type);

        Debug.Assert(_client != null);
        return await _client.GetAsync(request);
    }

    /// <summary>
    /// Computeサーバーの詳細なバージョン情報を取得するメソッド。
    /// </summary>
    /// <param name="token">取得したアクセストークン</param>
    /// <returns>Computeサーバーからのレスポンス</returns>
    public async Task<RestResponse> RequestInfoAsync(string token)
    {
        var url = "/v2";

        var request = new RestRequest(url, Method.Get);

        request.AddHeader(_http_header_Accept, _contents_type);
        request.AddHeader(_http_header_xAuthToken, token);

        Debug.Assert(_client != null);
        return await _client.GetAsync(request);
    }


}
