using Google.Cloud.Storage.V1;
using Microsoft.AspNetCore.Mvc;

namespace GcpStorageEmulatorUpload.Controllers;

[ApiController]
[Route("[controller]")]
public class UploadController : ControllerBase
{
    private readonly ILogger<UploadController> _logger;
    private readonly StorageClient _client;
    private const string BucketName = "test-bucket";

    public UploadController(ILogger<UploadController> logger)
    {
        _logger = logger;
        _client = new StorageClientBuilder()
        {
            BaseUri = "http://localhost:9023/storage/v1/",
            UnauthenticatedAccess = true,
        }.Build();

        try
        {
            _client.CreateBucket("test-project", BucketName);
        }
        catch {}
    }

    
    [HttpPost]
    public async Task<IActionResult> Upload(IFormFile file)
    {
        await _client.UploadObjectAsync(BucketName, "test", null, file.OpenReadStream());
        return Ok();
    }
}