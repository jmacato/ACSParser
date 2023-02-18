namespace ACSParser.DataStructures;

public class LANGID
{
    public USHORT LanguageID; // 2 bytes

    // TODO: Parse not tested.
    public static LANGID Parse(BinaryReader reader)
    {
        LANGID langid = new LANGID();

        langid.LanguageID = reader.USHORT();

        return langid;
    }
    
    public void Write(BinaryWriter writer)
    {
        writer.Write(LanguageID);
    }
}
