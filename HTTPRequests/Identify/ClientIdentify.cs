using ConohaVPS.HTTPRequests.Identify.JsonStructs;
using RestSharp;
using System.Diagnostics;
using System.Text.Json;

namespace ConohaVPS.HTTPRequests.Identify;

/// <summary>
/// Identifyサーバーとのやり取りを担うクラス。
/// </summary>
public class ClientIdentify
{
    private const string _http_header = "Accept";
    private const string _contents_type = "application/json";
    private const string _token_url = "/v2.0/tokens";
    private readonly RestClient _client;

    /// <summary>
    /// ClientIdentifyクラスのコンストラクタ。
    /// </summary>
    /// <param name="client">呼出先が持っているRestClientのインスタンス</param>
    public ClientIdentify(RestClient client)
    {
        _client = client;
    }

    /// <summary>
    /// IdentifyサーバーからConoHaVPSの各種APIへのアクセスに必要なアクセストークンを取得するメソッド。
    /// </summary>
    /// <param name="user_name">APIユーザー名。アカウントIDそのものではない</param>
    /// <param name="password">APIユーザーと紐づいたパスワード</param>
    /// <param name="tenant_id">APIユーザーと紐づいたテナントID</param>
    /// <returns>Identifyサーバーからのレスポンス</returns>
    public async Task<RestResponse> RequestTokenAsync(string user_name, string password, string tenant_id)
    {
        var param = new RequestTokenSerializeRoot
        {
            Auth = new Auth
            {
                PasswordCredentials = new PasswordCredentials
                {
                    Username = user_name,
                    Password = password,
                },
                TenantId = tenant_id,
            }
        };

        var json_param = JsonSerializer.Serialize(param);

        var request = new RestRequest(_token_url, Method.Post).AddJsonBody(json_param);

        request.AddHeader(_http_header, _contents_type);

        Debug.Assert(_client != null);
        return await _client.PostAsync(request);
    }

    /// <summary>
    /// Computeサーバーの基本的なバージョン情報を取得するメソッド。
    /// </summary>
    /// <returns>Identifyサーバーからのレスポンス</returns>
    public async Task<RestResponse> RequestInfoAsync()
    {
        var url = "/";

        var request = new RestRequest(url, Method.Get);
        request.AddHeader(_http_header, _contents_type);

        Debug.Assert(_client != null);
        return await _client.GetAsync(request);
    }

    /// <summary>
    /// Computeサーバーの詳細なバージョン情報を取得するメソッド。
    /// </summary>
    /// <returns>Identifyサーバーからのレスポンス</returns>
    public async Task<RestResponse> RequestVerboseInfoAsync()
    {
        var url = "/";

        var request = new RestRequest(url, Method.Get);
        request.AddHeader(_http_header, _contents_type);

        Debug.Assert(_client != null);
        return await _client.GetAsync(request);
    }
}