using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace SynHeimPatcher
{
    public class Settings
    {
        public ModKey HeimEspName = "Heim.esp";

        public Dictionary<string, IFormLinkGetter<IBookGetter>> KeywordToBookMapping = new();
    }
}