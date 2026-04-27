namespace TaloGameServices
{
    [System.Serializable]
    public class PlayersGameCenterIdentifier
    {
        public string publicKeyURL;
        public string signature; // base64 encoded
        public string salt; // base64 encoded
        public ulong timestamp;
        public string playerID;
        public string bundleID;
    }
}
