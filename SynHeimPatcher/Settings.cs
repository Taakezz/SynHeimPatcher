using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace SynHeimPatcher
{
    public class Settings
    {
        public ModKey HeimEspName = "Heim.esp";

        public IEnumerable<MappingEntry> KeywordToBookMapping = new List<MappingEntry>();

        public bool RenameBooks = false;

        public bool MakeBooksWeightless = false;
    }

    public class MappingEntry
    {
        public IFormLinkGetter<IKeywordGetter>? Keyword;

        public IFormLinkGetter<IBookGetter>? Book;
    }
}