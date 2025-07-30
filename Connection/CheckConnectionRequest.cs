using MemoryPack;
using SFServer.Shared.Client.Base;

namespace SFServer.Shared.Client.Connection
{
    [MemoryPackable]
    public partial class CheckConnectionRequest : SFRequest
    {
        public string Credential { get; set; }

        public string DeviceId { get; set; }

        public string BundleId { get; set; }
        public override string Endpoint => "connection/check";
        public override bool IsProject => false;
    }
}