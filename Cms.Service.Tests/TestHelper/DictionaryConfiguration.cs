using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;

namespace Cms.Service.Tests.TestHelper;

/// <summary>
/// Cấu hình (<see cref="IConfiguration"/>) dựa trên dictionary cặp key-value phẳng
/// (vd "AdminAuth:Username" → "admin"). Tự chứa, không phụ thuộc package
/// Microsoft.Extensions.Configuration.Memory (không có sẵn trong môi trường restore này).
/// </summary>
internal sealed class DictionaryConfiguration : ConfigurationRoot
{
    public DictionaryConfiguration(IEnumerable<KeyValuePair<string, string?>> values)
        : base(new[] { new DictionaryConfigurationProvider(values) })
    {
    }
}

internal sealed class DictionaryConfigurationProvider : ConfigurationProvider
{
    public DictionaryConfigurationProvider(IEnumerable<KeyValuePair<string, string?>> values)
    {
        foreach (var kv in values)
            Data[kv.Key] = kv.Value;
    }
}
