using MemoryPack;

namespace SFServer.Shared.Client.Base {
    public partial interface ISFRequest {
        [MemoryPackIgnore]
        public string Endpoint { get; }
        
        [MemoryPackIgnore]
        public bool IsProject { get; }
    }
}