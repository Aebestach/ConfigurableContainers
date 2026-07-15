using System;

namespace AT_Utils
{
    public class CCModInfo : KSP_AVC_Info
    {
        public CCModInfo()
        {
            MinKSPVersion = new Version(1, 12, 3);
            MaxKSPVersion = new Version(1, 12, 3);

            VersionURL =
                "https://github.com/Aebestach/ConfigurableContainers/raw/master/GameData/ConfigurableContainers/ConfigurableContainers.version";
            UpgradeURL = "https://spacedock.info/mod/1002/Configurable%20Containers";
        }
    }
}
